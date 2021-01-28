# Unity_ShootingGame
학부생 한명과 함께 2인개발
4방향에서 나오는 몬스터들을 물리치면서 보스 거미 몬스터를 물리치는 게임
StoneMonster는 불을 내뿜으면서 달려들고 ZomBunny는 달려들기만 한다.
보스몬스터는 위 아래로 독을 내뿜는다.
플레이어는 궁극기, 쉴드를 갖고있다.(쉴드는 시간이 지나면 계속 채워진다)

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
  
* 궁극기(공격속도, 3초간 무적/5초뒤 재사용 가능)
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
  - [파티클(이펙트)의 삭제](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/Destroy_Self.cs)
    - 총알에 붙은 파티클, 플레이어가 공격에 맞고 생긴 파티클, 궁극기 사용시 생기는 파티클을 없애주는 설정
  - [패배 시 장면전환](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/Lose_scene.cs)
    - 클릭 시 첫화면으로 돌아가서 다시 플레이 할 수 있도록 설정
  - [몬스터 체력](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/MonsterHealth.cs)
    - 체력 0이 되면 소리나면서 시체가 없어지도록 설정
  - [플레이어 설정](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/PlayerStat.cs)
    - 궁극기 설정(ultimate), 쉴드 설정(shield), 체력 설정, 보스의 공격이나 몬스터와의 충돌시 소리, 쉴드 및 체력 설정
    - 총알을 나가게하는 부분은 Tutorial에 있던 것 그대로 사용
  - [게임 시작 전 장면](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/Start_View.cs)
    - 아무키나 누르면 게임화면으로 넘어가게 설정
  - [총알 삭제](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/bullet_destroy.cs)
    - 물체에 맞지 않는 총알을 없애주기 위한 설정
  - [총알에 맞았을 때 파티클 생성](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/bullet_effect.cs)
  - [몬스터 충돌 시 파티클 생성](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/buuny_boom.cs)
  - [몬스터 이동](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/monster_move.cs)
    - NavMesh 사용
  - [몬스터의 공격](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/monster_shot.cs)
    - StoneMonster만 해당, LookAt을 사용해서 플레이어를 항상 바라보도록 설정
  - [플레이어를 따라 다니는 카메라 설정](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/smooth_follow.cs)
    - 수업시간에 사용했던 코드 그대로 사용
  - [스폰지역에서 몬스터가 계속 나오도록 설정](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/spawn_monster.cs)
  - [보스몬스터 공격](https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/spider_shot.cs)
    - 위, 아래에서 총알이 나가도록 설정
  - [테스트 한다고 만들었던 코드]https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/UI.cs , https://github.com/OGyoung/Unity-ShootingGame/blob/main/Assets/coding/target_move.cs
