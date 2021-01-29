using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservedAvatar : MonoBehaviour
{
	public static ObservedAvatar instance;
	public GameObject avatar;
	// Start is called before the first frame update
	void Start()
	{
		if (ObservedAvatar.instance) Destroy(this);
		ObservedAvatar.instance = this;
	}
	public GameObject getAvatar()
    {
		return avatar;
    }
	public void setAvatar(GameObject avatar)
    {
		this.avatar = avatar;
    }

	public void deleteAvatar()
    {
		this.avatar = null;
    }
}
