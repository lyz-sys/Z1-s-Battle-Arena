﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPoisonBehaviour : MonoBehaviour
{
    private SelectionManager SelectionManager;

    // Start is called before the first frame update
    void Start()
    {
        SelectionManager = GameObject.Find("Selection Manager").GetComponent<SelectionManager>();
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	private void OnTriggerStay2D(Collider2D collision)
	{
        if (SelectionManager.beingSelected && SelectionManager.cardName == transform.name)
        {
            //Debug.Log(true);
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log(false);
                collision.GetComponent<CardInfluenceBehaviour>().beingAffectedByPoision = true;
                SelectionManager.beingSelected = false;
                GameObject.Destroy(gameObject);
            }         
        }
    }
}
