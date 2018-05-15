using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    // Сдвиг камеры относительно позиции объекта
    private Vector3 offset;
    // Объект, за которым будет следить камера
    public GameObject target;
    // Use this for initialization
    void Start() {
        offset = target.transform.position - transform.position;
       
    }

    // Update is called once per frame
    void Update() { 

		// Обновляем положение камеры
        transform.position = target.transform.position - offset;
	}
}