/*
//Script by Child of the beast
//V 1.0
//https://github.com/ChildoftheBeast/VRC-UdonSharp-Scripts
*/
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;

public class Soccor : UdonSharpBehaviour
{
    public GameObject BlueGoal;
    public GameObject RedGoal;
    public GameObject Ball;
	
	public GameObject BlueScore1;
	public GameObject BlueScore2;
	public GameObject BlueScore3;
	public GameObject BlueScore4;
	
	public GameObject RedScore1;
	public GameObject RedScore2;
	public GameObject RedScore3;
	public GameObject RedScore4;
	
    public Text RedTeamScore;
    public Text BlueTeamScore;
	
    public GameObject[] particlesRed;
    public GameObject[] particlesBlue;
	
    [UdonSynced]private int Cup;
	
    public int BlueTeamScoreint = 0;
    public int RedTeamScoreint = 0;
	
	public GameObject BallSpawn;
    private Vector3 Ball_Spawn;
	
	private void Start()
    {
        Ball_Spawn = BallSpawn.transform.position;
		BlueScore1.SetActive(false);
		BlueScore2.SetActive(false);
		BlueScore3.SetActive(false);
		BlueScore4.SetActive(false);
		RedScore1.SetActive(false);
		RedScore2.SetActive(false);
		RedScore3.SetActive(false);
		RedScore4.SetActive(false);
    }
	
    public void OnTriggerExit(Collider other)
    {
		
        if (other.transform.parent == BlueGoal.transform) 
        {
			if (RedScore1.activeSelf == false)
			{
				RedScore1.SetActive(true);
				RedScore2.SetActive(false);
				RedScore3.SetActive(false);
				RedScore4.SetActive(false);
				Networking.SetOwner(Networking.LocalPlayer, Ball);
				Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
				Ball.transform.position = Ball_Spawn;
			}
			else 
			{ if(RedScore2.activeSelf == false)
				{
				RedScore1.SetActive(true);
				RedScore2.SetActive(true);
				RedScore3.SetActive(false);
				RedScore4.SetActive(false);
				Networking.SetOwner(Networking.LocalPlayer, Ball);
				Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
				Ball.transform.position = Ball_Spawn;
				}
				else
				{ if(RedScore3.activeSelf == false)
					{
						RedScore1.SetActive(true);
						RedScore2.SetActive(true);
						RedScore3.SetActive(true);
						RedScore4.SetActive(false);
						Networking.SetOwner(Networking.LocalPlayer, Ball);
						Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
						Ball.transform.position = Ball_Spawn;
					}
					else
					{ if(RedScore4.activeSelf == false)
						{
							RedScore1.SetActive(true);
							RedScore2.SetActive(true);
							RedScore3.SetActive(true);
							RedScore4.SetActive(true);
							Networking.SetOwner(Networking.LocalPlayer, Ball);
							Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
							Ball.transform.position = Ball_Spawn;
						}
						else
						{
							BlueScore1.SetActive(false);
							BlueScore2.SetActive(false);
							BlueScore3.SetActive(false);
							BlueScore4.SetActive(false);
							RedScore1.SetActive(false);
							RedScore2.SetActive(false);
							RedScore3.SetActive(false);
							RedScore4.SetActive(false);
						}	
					}
				}
			}	
				
        }
        if (other.transform.parent == RedGoal.transform)
        {
			if (BlueScore1.activeSelf == false)
			{
				BlueScore1.SetActive(true);
				BlueScore2.SetActive(false);
				BlueScore3.SetActive(false);
				BlueScore4.SetActive(false);
				Networking.SetOwner(Networking.LocalPlayer, Ball);
				Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
				Ball.transform.position = Ball_Spawn;
			}
			else 
			{ if(BlueScore2.activeSelf == false)
				{
				BlueScore1.SetActive(true);
				BlueScore2.SetActive(true);
				BlueScore3.SetActive(false);
				BlueScore4.SetActive(false);
				Networking.SetOwner(Networking.LocalPlayer, Ball);
				Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
				Ball.transform.position = Ball_Spawn;
				}
				else
				{ if(BlueScore3.activeSelf == false)
					{
						BlueScore1.SetActive(true);
						BlueScore2.SetActive(true);
						BlueScore3.SetActive(true);
						BlueScore4.SetActive(false);
						Networking.SetOwner(Networking.LocalPlayer, Ball);
						Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
						Ball.transform.position = Ball_Spawn;
					}
					else
					{ if(BlueScore4.activeSelf == false)
						{
							BlueScore1.SetActive(true);
							BlueScore2.SetActive(true);
							BlueScore3.SetActive(true);
							BlueScore4.SetActive(true);
							Networking.SetOwner(Networking.LocalPlayer, Ball);
							Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
							Ball.transform.position = Ball_Spawn;
						}
						else
						{
							BlueScore1.SetActive(false);
							BlueScore2.SetActive(false);
							BlueScore3.SetActive(false);
							BlueScore4.SetActive(false);
							RedScore1.SetActive(false);
							RedScore2.SetActive(false);
							RedScore3.SetActive(false);
							RedScore4.SetActive(false);
						}	
					}
				}
			}
        }
    }
	public void Update()
	{
		RedTeamScore.text = RedTeamScoreint.ToString();
		BlueTeamScore.text = BlueTeamScoreint.ToString();
	}
    public void RespawnBall()
    {
        Networking.SetOwner(Networking.LocalPlayer, Ball);
        Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Ball.transform.position = Ball_Spawn;
    }
    public void fireEffectsBlue()
    {
        foreach (GameObject obj in particlesBlue)
        {
            obj.SetActive(false);
            obj.SetActive(true);
        }
    }
    public void fireEffectsRed()
    {
        foreach (GameObject obj in particlesRed)
        {
            obj.SetActive(false);
            obj.SetActive(true);
        }
    }
}