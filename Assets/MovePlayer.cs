using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;


public class MovePlayer : MonoBehaviour, PlayerAct.IPlatformActionActions
{
    PlayerAct.PlatformActionActions input;

    [SerializeField] MoveComponent move;
    float horizontal;

    void Awake()
    {
        // インプットを生成して、自身をコールバックとして登録
        input = new PlayerAct.PlatformActionActions(new PlayerAct());
        input.SetCallbacks(this);
    }

    // インプットの有効・無効化
    void OnDestroy() => input.Disable();
    void OnEnable() => input.Enable();


    void OnDisable() => input.Disable();
    void Update() => move.MoveHorizontal(horizontal);

    // --------------
    // コールバック
    // --------------
    public void OnJump(InputAction.CallbackContext context)
    {
        move.Jump();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        // 押しっぱなしの動作は、直接オブジェクトを動かすのではなく方向性のみを登録する
        horizontal = context.ReadValue<Vector2>().x;
    }
}
