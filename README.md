# Unity_ShootingGame
학부생 한명과 함께 2인개발
4방향에서 나오는 몬스터들을 물리치면서 보스 거미 몬스터를 물리치는 게임
플레이어는 필살기와 쉴드를 갖고있다.(쉴드는 시간이 지나면 계속 채워진다)

## 승리 장면
![승리](https://user-images.githubusercontent.com/52282493/106029265-429eb380-6110-11eb-8719-cd0f9174f855.gif)

## 패배 장면
![패배](https://user-images.githubusercontent.com/52282493/106029251-3dd9ff80-6110-11eb-9794-58a8b38fde43.gif)

## 조작법
* 이동
   * WSAD키    
   * ↑↓←→키
   
* 공격
  * 마우스 왼쪽 클릭
  
* 필살기(공격속도, 3초간 무적/5초뒤 재사용 가능)
  * R키
 

## 사용한 자료
- AssetStroe에서 무료로 제공하는 에셋 사용
  - [파티클]https://assetstore.unity.com/packages/vfx/particles/fire-explosions/procedural-fire-141496
  - [몬스터]https://assetstore.unity.com/packages/3d/characters/stone-monster-101433
  - [보스몬스터]https://assetstore.unity.com/packages/3d/characters/animals/insects/spider-green-11869
  - [기둥]https://assetstore.unity.com/packages/3d/props/feline-gargoyle-27106

- Unity Survival Shooter Tutorial 사용
  - [플레이어 캐릭터 및 애니메이션][몬스터]https://learn.unity.com/project/survival-shooter-tutorial?language=en

## 작성한 코드
- [code](https://github.com/OGyoung/Unity-ShootingGame/tree/main/Assets/coding)
  - [보스몬스터 체력](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/BossHealth.cs)
    - 체력이 줄 때마다 타격 소리가 나고 체력이 0아래로 떨어지면 승리 장면으로 전환
  - [보스 및 플레이어 총알 자동삭제](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/Destroy_Self.cs)
    - 몬스터 또는 플레이어에 맞지 않았을 경우의 총알 삭제
  - [패배 시 장면전환](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/Lose_scene.cs)
    - 클릭 시 첫화면으로 돌아가서 다시 플레이 할 수 있도록 설정
  - [몬스터 체력](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/MonsterHealth.cs)
    - 체력 0이 되면 소리나면서 시체가 없어지도록 설정
  - [플레이어 설정](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/PlayerStat.cs)
    - 필살기 설정(ultimate), 쉴드 설정(shield), 체력 설정, 보스의 공격이나 몬스터와의 충돌시 소리, 쉴드 및 체력 설정
    - 총알을 나가게하는 부분은 Tutorial에 있던 것 그대로 사용
