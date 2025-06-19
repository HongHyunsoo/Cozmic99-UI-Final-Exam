using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
  
        public float speed = 1f; // 이동 속도
        public float resetX = -10f; // 다시 오른쪽으로 보낼 위치
        public float startX = 10f;  // 화면 밖 오른쪽 시작 위치

        void Update()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            // 왼쪽 끝까지 가면 다시 오른쪽에서 시작
            if (transform.position.x < resetX)
            {
                Vector3 pos = transform.position;
                pos.x = startX;
                transform.position = pos;
            }
        }
    }
