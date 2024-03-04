using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShorterGun : MonoBehaviour
{
    [SerializeField] private GameObject m_bloodBall;
    [SerializeField] private GameObject m_EletroBall;
    [SerializeField] private GameObject m_waterBall;
    [SerializeField] private float m_FireRateOfShoting;


    private Rigidbody m_bullets;


    private void Awake()
    {

        m_bullets = GetComponent<Rigidbody>();
    }

    void Start()
    {

    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("ShootB", 0.5f, m_FireRateOfShoting);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            InvokeRepeating("ShootE", 0.5f, m_FireRateOfShoting);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CancelInvoke();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            InvokeRepeating("ShootW", 0.5f, m_FireRateOfShoting);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            CancelInvoke();
        }
        //if (Input.GetKey(KeyCode.Space))
        //{
        //     Instantiate(m_bulletstY, transform.position, Quaternion.identity);

        //    //Instantiate(m_bulletstY, transform.position , Quaternion.identity);
        //}
        //if (Input.GetKey(KeyCode.E))
        //{
        //    Instantiate(m_bulletstR, transform.position, Quaternion.identity);

        //    //Instantiate(m_bulletstR, transform.position , Quaternion.identity);
        //}
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    Instantiate(m_bulletstB, transform.position, Quaternion.identity);

        //    //Instantiate(m_bulletstB, transform.position , Quaternion.identity);
        //}

    }
    private void ShootB()
    {
        Instantiate(m_bloodBall, transform.position, Quaternion.identity);
    }
    private void ShootE()
    {
        Instantiate(m_EletroBall, transform.position, Quaternion.identity);
    }
    private void ShootW()
    {
        Instantiate(m_waterBall, transform.position, Quaternion.identity);
    }

}



