using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ManageCollectors : MonoBehaviour
{
    public static ManageCollectors instance;

    string[] folders;
    public int numberForCurrentIteration;
    string iniPath = "Assets/Data/";
    // Start is called before the first frame update
    void Awake()
    {
        if (ManageCollectors.instance) Destroy(this);
        ManageCollectors.instance = this;
        int highestDireNum = 0;

        if (!Directory.Exists(iniPath)){
            Directory.CreateDirectory(iniPath);
        }
        folders = Directory.GetDirectories(iniPath);
        foreach (string currentFolder in folders)
        {
            string num = currentFolder[currentFolder.Length - 1].ToString();

            if (currentFolder[currentFolder.Length-2]!='/') // si el penultimo caracter es un numero, lo cogeremos tambien.
            {
                num = currentFolder[currentFolder.Length - 2].ToString() + num;
                
            }
            int comparableNum = int.Parse(num);
            if (highestDireNum < comparableNum) highestDireNum = comparableNum;
        }
        numberForCurrentIteration = highestDireNum + 1;
        Directory.CreateDirectory(iniPath+ numberForCurrentIteration.ToString());
    }

    public string pathForCurrentIteration()
    {
        string path = iniPath + numberForCurrentIteration.ToString();
        return path;
    }

    private void Start()
    {
        
    }
}
