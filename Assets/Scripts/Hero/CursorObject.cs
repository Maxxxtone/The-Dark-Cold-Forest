using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorObject : MonoBehaviour
{
    public static CursorObject cursor;
    private InputMaster _input;
    private Camera _mainCamera;
    private void Awake()
    {
        cursor = this;
        _input = new InputMaster();
        _mainCamera = Camera.main;
    }
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        Vector3 mousePos = _mainCamera.ScreenToWorldPoint(_input.Cursor.MousePosition.ReadValue<Vector2>());
        mousePos.z = 10;
        transform.position = mousePos;
    }
}
