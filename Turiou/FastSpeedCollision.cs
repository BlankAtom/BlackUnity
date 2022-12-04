/**
一、更换碰撞检测器
1, 使用Discrete（离散型检测，是默认检测）
2，Continuous（连续检测，更精确的碰撞检测，很耗费资源，与普通刚体碰撞使用Discrete）
2，Continuous dynamic（动态连续碰撞，对没有刚体的Mesh或处于Continuous状态下的刚体使用的，很耗费资源，与普通刚体碰撞使用Discrete）
4，Continuous Speculative（扫描连续碰撞，静止时不检测，有位移时检测）


二、射线检测
先使用射线检测碰撞点，再移动，利用记录点来限制移动距离


*/

public class Sample : MonoBehaviour {
    void Update(){
        var oriPos = transform.position;
        var direction = transform.position - oriPos;
        var hitinfo = new RaycastInfo();
        Physics.Raycast(oriPos, direction, out hitinfo, length);
    }
}