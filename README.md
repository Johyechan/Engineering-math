# Engineering-math

**1일차 벡터(벡터의 덧셈)**


벡터란 크기와 방향을 가진 값이다.


보통은 2D나 3D 공간에서 위치나 움직임을 표현할 때 많이 사용한다.


2D 벡터 형태: v = (x,y)


3D 벡터 형태: v = (x,y,z)


오늘은 우선적으로 벡터의 덧셈에 대해서 공부해볼 생각이다.


벡터의 덧셈은 두 벡터 a, b를 더한다고 생각했을 때 각 좌표를 더하는 방식으로 계산한다.


a + b = (ax, ay) + (bx, by) = (ax + bx, ay + by)


2D 벡터 형태: (1,2) + (3,4) = (1 + 3, 2 + 4) = (4,6)


3D 벡터 형태: (1,2,3) + (4,5,6) = (1 + 4, 2 + 5, 3 + 6) = (5,7,9)


그래픽적으로 생각했을 경우에 벡터의 덧셈은 두 벡터를 이어서 그리고 시작점에서 끝점까지의 벡터를 구하는 과정이다.


평행사변형 법칙으로 생각하면 쉽다.


두 벡터 a,b에 대하여 평행사변형 법칙을 적용하면


 1. a를 그린다.
 2. a의 시작점에서 b를 그린다.
 3. b와 평행하는 변b1을 a의 끝점에서 그린다.
 4. a와 평행하는 변a1을 b의 끝점에서 그린다.
 5. a와b의 시작점에서 a1과 b1의 끝점까지의 벡터가 결과 값이 된다.


벡터 덧셈의 성질로는


 1. 교환 법칙 (덧셈의 순서가 바뀌어도 결과 값이 똑같다.)
 2. 결합 법칙 (세 개 이상의 벡터를 더할 때 순서는 상관없다.)


정도가 있다.


벡터의 덧셈을 활용해서 총알 발사와 플레이어 움직임을 구현해봤다.


실제로 wasd로 움직이면 transform을 변경하는 형식으로 움직이게 하였고 잘 움직였다.


화살표로 움직이면 RigidBody를 이용하여 물리적으로 힘을 받고 움직여지는 형식으로 만들었고 좀 이상하지만 그래도 잘 움직였다.


그리고 총알 발사 또한 RigidBody를 사용하였고 잘 발사되었다.
