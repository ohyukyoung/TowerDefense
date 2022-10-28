using System;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 1.0f;

    public float startHealth;   // 시작 체력
    private float health;   // 현재 체력
    private Transform target;
    private int wavepointIndex = 0;
    public GameObject impactEffect; // 얼음 깨지는 효과
    private int count = 0;    // 얼음 깨지는 카운트

    public Image healthBar;


    private void Start()
    {
        target = Waypoints.points[0];
        

        // 현재 자식 오브젝트[0]==Enemy1태그 오브젝트
        if (transform.GetChild(0).gameObject == GameObject.FindWithTag("Enemy1")) // 여우 체력 설정
        {
            startHealth = Variables.Enemy1StartHealth;
        }
        else    // 슬라임 체력 설정
        {
            startHealth = Variables.Enemy2StartHealth;
        }

        health = startHealth;
    }
    
    

    private void Update()
    {

        Vector3 directionToTarget = target.position - transform.position;   // 초당으로 계산
        transform.Translate(directionToTarget.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }

        Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);
        transform.rotation = rotationToTarget;

       
    }

    // 다음 waypoint 향해 이동
    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);    // 결승 도착시 소멸
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];  // 다음 waypoint
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth; // fillAmount 값 0~1

        count++;    // 데미지 입을 때 카운트 1 증가
        IceImpactEffect();
        DieIce();

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        GameObject.FindWithTag("Shop").GetComponent<Shop>().AddCoin(50);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")   // 결승점에 적이 닿을 경우
        {
            GameObject.FindWithTag("Player").GetComponent<EndHealthBar>().TakeDamage(); // 체력 1씩 감소

        }
        
    }

    // 카운트가 1일 때만 얼음 깨지는 효과 생성
    private void IceImpactEffect()
    {
        if(count== 1)
        {
            GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(effectIns, 0.7f);
        }
        count++;    // 카운트는 2로 바뀜
    }

    // 카운트가 2일 때만 얼음 소멸
    private void DieIce()
    {
        if(count==2)
        {
            Destroy(GameObject.FindWithTag("Ice"));
        }
        count++;    // 카운트는 3이 됨
    }
}