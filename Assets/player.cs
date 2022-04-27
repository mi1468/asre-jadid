using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public string color1 = "gray";
    public string color2 = "gray";
    public string color3 = "gray";
    public string color4 = "gray";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           if (Input.GetMouseButtonDown(0)) {  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  
                //Select stage    
                if (hit.transform.name == "1") {  
                    if(color1 == "gray")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.white);

                        }
                        color1 = "white";
                    }    
                    else if(color1 == "white")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.red);

                        }
                          color1 = "red";
                    }    
                     else if(color1 == "red")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.black);

                        }
                          color1 = "black";
                    }    
                    
                }  
                if (hit.transform.name == "2") {  
                    if(color2 == "gray")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.white);

                        }
                        color2 = "white";
                    }    
                    else if(color2 == "white")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.red);

                        }
                          color2 = "red";
                    }    
                     else if(color2 == "red")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.black);

                        }
                          color2 = "black";
                    }    
                    
                }  
                if (hit.transform.name == "3") {  
                 
                    if(color3 == "gray")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.white);

                        }
                        color3 = "white";
                    }    
                    else if(color3 == "white")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.red);

                        }
                          color3 = "red";
                    }    
                     else if(color3 == "red")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.black);

                        }
                          color3 = "black";
                    }    
                    
                }  
                if (hit.transform.name == "4") {  
                 
                    if(color4 == "gray")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.white);

                        }
                        color4 = "white";
                    }    
                    else if(color4 == "white")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.red);

                        }
                          color4 = "red";
                    }    
                     else if(color4 == "red")
                    {
                        for (int i = 0; i < hit.transform.childCount ; i++)
                        {
                            var cubeRenderer = hit.transform.GetChild(i). GetComponent<Renderer>();
                            cubeRenderer.material.SetColor("_Color", Color.black);

                        }
                          color4 = "black";
                    }    
                    
                }  
            }  
    }  
    }
}
