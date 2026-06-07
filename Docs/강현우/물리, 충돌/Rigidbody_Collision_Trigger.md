# Collider, Rigidboy 적용 시 작둉

## Is Trigger, Use Gravity, Is Kinematic 각각 적용에 따라 달라지는 오브젝트

1. Trigger ON + Gravity ON: 
    -> Trigger라서 바닥과 물리 충돌 안 함. Gravity 때문에 아래로 떨어져서 바닥 뚫음       

2. Trigger OFF + Kinematic OFF + Gravity OFF: 중력은 없지만 Collider가 바닥과 겹쳐 있으면 물리 엔진이 겹침을 밀어내서 바닥 위로 뜸

3. Trigger ON만: 

    -> Gravity OFF라서 아래로 안 떨어짐. Trigger라 충돌도 안 함. 그래서 현재 위치 유지

4. Trigger ON + Gravity ON + Kinematic ON: 

    -> Kinematic이 물리 이동을 막음. Gravity도 무시됨. 그래서 안 떨어짐

5. Gravity ON만: 

    -> 중력으로 떨어지다가 바닥 Collider와 충돌해서 바닥 위에 멈춤. Collider 높이만큼 떠 보임

6. Gravity ON + Kinematic ON: Kinematic 때문에 Gravity 무시. 물리 이동 안 함. 현재 위치 유지             |

7. Kinematic ON + Trigger ON: Kinematic이라 물리 이동 안 함. Trigger라 충돌 반응도 없음. 현재 위치 유지

8. Kinematic ON만: 물리 엔진이 안 움직임. Gravity도 충돌 밀림도 적용 안 됨. 현재 위치 유지   

9. 아무것도 체크 안 함: Gravity OFF지만 Collider가 바닥과 겹치면 물리 엔진이 겹침을 해결하려고 위로 밀어냄
