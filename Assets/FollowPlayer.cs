using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
    public Transform target;    // ターゲットへの参照
    public Vector3 offset = new Vector3(0f, 1f, 0f);

    void Start()
    {
        //自分自身とtargetとの相対距離を求める
        GetComponent<Transform>().position = target.position + offset;
    }
	
	// Update is called once per frame
	void Update () {
        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
        GetComponent<Transform>().position = target.position + offset;

    }
}
