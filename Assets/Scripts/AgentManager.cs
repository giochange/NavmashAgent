using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{

    GameObject[] agents;

    // Start is called before the first frame update
    void Start()
    {
       // pegada da posição do objeto com tag "ai" fazendo assim fução de busca
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {
        //condicionamento de ação perante ao click do mouse
        if (Input.GetMouseButtonDown(0))
        {
            //criação do raycast para identificação  do solo setando assim em comparação com a posição que foi clicada pelo mouse.
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                //resultado do condicionamento que resulta no endereçamento dos pontos clicados e ao mesmo tempo guardando a posição
                foreach (GameObject a in agents)
            a.GetComponent<AIControl>().agent.SetDestination(hit.point);


            }

        }

    }
}
