# Animation 2D

## ⭐ Sprite Animation

### ✅ 개념

1. sprite를 일련 시간으로 변화시키는 것.
2. 스프라이트를 사용한 애니메이션은 캐릭터의 움직임에 대한 스프라이트를 가지고 있는 아틀라스를 기반으로 생성할 수 있다.

### ✅ 특징

1. 관리하기 편함
2. 메모리 효율이 좋음(GPU 바인딩 비용 감소, 캐싱 효율)

### Sprite Animation 핵심 요소

#### 🎯 Atlas 

1. 개념: 여러 sprite 이미지를 단일 텍스쳐로 결합한 형태
2. 특징
    ```
    a. 2D 게임에서 배경, 캐릭터 등의 sprite 이미지를 매번 랜더링 할 때 마다 각 sprite 별 1의 Batches가 증가하고 Draw Call도 증가 그에 따라 프레임 저하 현상이 일어난다. 그래서 Atlas를 이용해서 여러 sprite 이미지를 한 장의 텍스처로 모아서 사용하여 이 문제점을 보완한다.
    ```

#### 🎯 Draw Call

1. 개념: CPU가 GPU에게 어떤 그림을 그려 달라고 요청하는 것
2. 특징
    ```
    a. Draw Call 값이 적을수록 게임이 부드러우며, 이 값이 많아지면 프레임 저하가 발생
    ```

#### 🎯 Batches

1. 개념
    ```
    a.Draw Call을 포함하는 상위 개념. 
    b. Unity 5.0부터 Draw Call 대신 Batches를 기준으로 “Stats”에 렌더링 정보를 표현.
    ```

2. 특징
    a. Mesh, Material, Shader, Draw Call 등의 정보를 종합적으로 계산.


## 참고자료

- Atlas

    1. https://minii22.tistory.com/98
    2. https://rootdev.tistory.com/78