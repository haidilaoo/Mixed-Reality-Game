using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float _mHorizontalInput   = 0.0f;
    float _mVerticalInput     = 0.0f;
    float _mSpeed = 0.0f;
    Vector3 _mDirectionInput;

    [SerializeField]
    private AudioSource _mAudioSource;

    

    //[SerializeField]
    //private AudioClip[] mAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        _mSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        _mHorizontalInput = Input.GetAxis("Horizontal");
        _mVerticalInput   = Input.GetAxis("Vertical");
        //print(_mHorizontalInput + " " + _mVerticalInput);

        _mDirectionInput = new Vector3(_mHorizontalInput, _mVerticalInput, 0);
        transform.Translate(_mDirectionInput * _mSpeed * Time.deltaTime);

        

    }

}
