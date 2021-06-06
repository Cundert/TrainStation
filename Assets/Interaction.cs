using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public AudioSource audioSource;
    bool isFemale;
    public int lastLocation;
    public bool greeted;
    public GameObject spawnableObject;
    public FSMcontroller FSMgate;

    public GameObject userRightHand;
    public GameObject ticketSpawned;
    public GameObject ticketToBeGiven;

    float greetedTimer;

    void Start()
    {
        greeted = false;
        lastLocation = -1;
        audioSource = GetComponent<AudioSource>();
        isFemale = transform.name.Contains("F");
        greetedTimer = 0.2f;
    }

    private void Update()
    {
        if (greeted)
        {
            greetedTimer -= Time.deltaTime;
            if (greetedTimer <= 0)
            {
                greeted = false;
                greetedTimer = 0.2f;
            }
        }
        //userInWorkerArea = PlayerInWorkerArea();
    }
    public void startLookingAt(Quaternion q)
    {
        StartCoroutine("lookAtCoroutine",q);
    }

    public void SpawnTicketInUserHand()
    {
        ticketSpawned = Instantiate(ticketToBeGiven, userRightHand.transform);
        ticketSpawned.transform.position = userRightHand.transform.position;
    }

    public void TicketValidated()
    {
        FSMgate.customFlag = true; // El custom flag indica que  el ticket ha sido validado.
    }

    IEnumerator lookAtCoroutine(Quaternion q)
    {
        float elapsedTime = 0;
        float time = 0.65f;
        Quaternion startingRotation = transform.rotation;
        while (elapsedTime < time)
        {
            elapsedTime += Time.deltaTime; // <- move elapsedTime increment here

            transform.rotation = Quaternion.Slerp(startingRotation, q, (elapsedTime / time));
            yield return new WaitForEndOfFrame();
        }

        yield return null;
    }
    public void GiveTicket()
    {
        spawnableObject.SetActive(true);
    }

    public void AnswerQuestion(int answer) {
        if (isFemale)
        {
            AudioClip ac = VoiceAnswers.instance.female[answer];
            audioSource.PlayOneShot(ac);
        }
        else
        {
            AudioClip ac = VoiceAnswers.instance.male[answer];
            audioSource.PlayOneShot(ac);
        }
        lastLocation = answer;
    }
    public void WorkerSays(int sentence)
    {
        if (isFemale)
        {
            AudioClip ac = VoiceAnswers.instance.wFemale[sentence];
            audioSource.PlayOneShot(ac);
        }
        else
        {
            AudioClip ac = VoiceAnswers.instance.wMale[sentence];
            audioSource.PlayOneShot(ac);
        }
        lastLocation = sentence;
    }


    public void Say(AudioClip female, AudioClip male)
    {
        if (isFemale)
        {
            audioSource.PlayOneShot(female);
        }
        else
        {
            audioSource.PlayOneShot(male);
        }
    }

    public void Say(AudioClip[] female, AudioClip[] male)
    {
        int random = Random.Range(0, female.Length);

        if (isFemale)
        {
            audioSource.PlayOneShot(female[random]);
        }
        else
        {
            audioSource.PlayOneShot(male[random]);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("SimpleTicket"))
        {
            GetComponent<FSMcontroller>().customFlag = true; // El custom flag indica que ha recibido el ticket.
            Destroy(other.gameObject);
        }
    }
}
