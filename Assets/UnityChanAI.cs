using UnityEngine;
using System.Collections;

public class UnityChanAI : MonoBehaviour
{
    private UnityChan.UnityChanAIControlScriptWithRgidBody script;    //ユニティちゃんの移動＆アニメーション関連のスクリプト
    public Transform goal;
    private Transform tr;
    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        script = gameObject.GetComponent<UnityChan.UnityChanAIControlScriptWithRgidBody>();
        script.KeyForward = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion heading = Quaternion.LookRotation(goal.position - tr.transform.position);
        float angle = Mathf.DeltaAngle(tr.transform.rotation.y, GetDest().y);
        //角度が急だと目的地の周りで円運動し続けるので、角度が大きい時は回転の量を増やす。
        if (Mathf.Abs(angle) < 60)
        {
            tr.transform.rotation = Quaternion.RotateTowards(tr.transform.rotation, heading, 90 * Time.deltaTime);
        }
        else
        {
            tr.transform.rotation = Quaternion.RotateTowards(tr.transform.rotation, heading, 180 * Time.deltaTime);
        }
    }


    Vector3 GetDest()
    {
        Vector3 heading = goal.position - tr.transform.position;
        heading.y = 0;

        return Quaternion.LookRotation(heading).eulerAngles;
    }
}
