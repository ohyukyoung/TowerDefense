### Game Development Using Unity
# TowerDefense Game

##### 성신여자대학교 정보시스템공학과
##### 개발 기간: 2022.05 ~ 2022.07
##### 2022 학기 중 프로젝트 만들기

 ---
 # 목록 :clipboard:
 * [프로젝트 소개](#프로젝트-소개)
   * 시작 배경
   * 간트차트, 기능 명세서
   * 직면했던 문제
   * 추가하고 싶은 기능들
   * 프로젝트를 통해 배운 것
 * [시작 가이드](#시작-가이드)
 * [스택](#스택)
 * [화면 구성](#화면-구성)
 * [주요 기능](#주요-기능)
 * [최종 게임 영상](#최종-게임-영상)
# 프로젝트 소개

#### :zap:시작 배경 

2021 여름방학 때 학교에서 주최하는 공모전에 나가기 위해 시작하였다. 평소 게임에 관심이 많았기 때문에 자연스럽게 주제는 게임으로 정했다. 하지만 그동안 유니티를 사용하여 게임 개발을 해본적이 없었기 때문에 처음부터 온전히 개발을 시작할 수는 없었다. 소스가 가장 많았던 RPG 게임의 소스를 클론 코딩하면서 진행하였다. 4명의 팀원들과 진행하였고, 각자 하나의 주제를 정해서 맵을 4개씩 만들었다. 

#### :zap: 간트차트, 기능 명세서
간트차트 | 기능 명세서
--- | --- |
![image](https://user-images.githubusercontent.com/90199652/198581665-3ce28eff-9722-40ff-a664-9e5910592939.png)|![image](https://user-images.githubusercontent.com/90199652/198581737-b536f78f-8c4b-4afc-868e-59a987d66357.png)

#### :zap: 직면했던 문제
우리가 직면했던 문제점 중 가장 큰 문제점은 코로나로 인해 직접 만나지 못하고 화상회의만 했던 점이다. 직접 만나지 못했기 때문에 소통이 그만큼 잘 되지 않았다. 또한 팀원 모두 유니티 사용과 c# 사용이 처음이었기 때문에 한명이 오류가 나거나 해결책을 모르면 다른 팀원이 도와줄 때 시간이 오래걸렸다. 유니티 에셋 스토어의 여부를 몰랐기 때문에 모든 도트를 직접 만들었는데 그 덕분에 특색은 있지만 초반에 시간이 많이 소요됐다.

#### :zap: 추가하고 싶은 기능들
시간적인 여유가 많지 않았기 때문에 아쉬움이 많이 남는다. 우선 첫번째로 추가하고 싶은 기능은 쿠키를 만들어 기존에 했던 게임에 이어서 할 수 있는 기능이다. 아직 깨지 못한 스테이지는 잠금을 걸고 기존 스테이지를 깨야지만 다음 스테이지를 시도할 수 있는 방법으로 만들어보고 싶다. 두번째로는 사용자 로그인을 할 수 있는 기능을 만들고 싶다. 데이터베이스와 화면 구성 등을 하며 프론트엔드와 백엔드를 결합하는 것을 해보고싶다.

#### :zap: 프로젝트를 통해 배운 것
가장 크게 배운 것은 협업하는 능력이다. 혼자 개발할 때와는 다르게 신경써야할 것도 많고 민폐가 될까봐 더 열심히 했던 것 같다. 한명의 팀원이 약간 뒤쳐진다면 같이 갈 수 있게 노력하는 것도 배운 것 같다. 
또한 유니티를 이용하여 개발하는 방법도 배웠다. 유니티에 내장되어있는 기능이 많기 때문에 게임을 개발 할 때 많은 부담이 되지 않았고, 만약 다음에 누군가가 게임 개발을 하라고 한다면 겁을 먹지 않을 것 같다. 

 
# 시작 가이드

### Requirement

For building and running the game you need:

* [Unity Hub 3.4.1](https://unity.com/kr/download)
* [Unity 2020.03.30f](https://unity.com/kr/releases/editor/whats-new/2020.3.30)
 
 # 스택 
 ### environment
<img  src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white"> <img  src="https://img.shields.io/badge/Visual Studio-5C2D91?style=for-the-badge&logo=visual studio&logoColor=white"> <img  src="https://img.shields.io/badge/github-181717?style=for-the-badge&logo=github&logoColor=white">

### development
<img  src="https://img.shields.io/badge/C-7952B3?style=for-the-badge&logo=C#&logoColor=white"> <img  src="https://img.shields.io/badge/android-3DDC84?style=for-the-badge&logo=Android&logoColor=white">


### communication
<img  src="https://img.shields.io/badge/zoom-7952B3?style=for-the-badge&logo=C# &logoColor=white"> <img  src="https://img.shields.io/badge/google meet-00897B?style=for-the-badge&logo=googlemeet&logoColor=white"> <img  src="https://img.shields.io/badge/google colab-F9AB00?style=for-the-badge&logo=google colab&logoColor=white">

# 화면 구성
시작 화면 | 목록 화면
--- | --- |
![image](https://user-images.githubusercontent.com/90199652/225842114-371aef40-e642-400b-9dfe-7f8bb08c5bb2.png)  | ![image](https://user-images.githubusercontent.com/90199652/225842458-9cff7fe7-322e-4238-8b8a-f80b6269379d.png)
도움말 | 게임 화면 
![image](https://user-images.githubusercontent.com/90199652/225842871-392e8285-4455-4d6d-aeca-2e6ef52a9d31.png) |![image](https://user-images.githubusercontent.com/90199652/225843193-b119ec40-fde9-46e6-b4ff-8ae9b6e6c455.png)

# 주요 기능
#### :sparkles: 4개의 다른 테마
* 4개의 큰 테마가 있는데 각 테마별로 어울리는 노래 삽입
* 각 테마 별로 다른 모습을 하고 있는 적
* 각 테마 별 적을 처치하는 방법과 게임을 깨는 법의 차이
* 각 테마 별 다른 배경화면을 보며 즐거움 선사 가능
#### :sparkles: 게임을 쉽게 해주는 옵션
* 테마별로 게임 방식이 다르기 때문에 각 테마 별로 해결 방법을 따로 제공
* 게임 시작 후 :question: 버튼을 누르게 되면 옵션 확인 가능
#### :sparkles: 게임 내부에 있는 각종 버튼
* 다시하기, 이어서 하기, 메인 화면으로 돌아가기 버튼 존재


# 최종 게임 영상
수룡아 졸업해야지! :movie_camera: [최종 영상](https://blog.naver.com/oouk1/222670106251)

### 화면 설계서, 기능 명세서
#### 최종 결과와는 약간 다르지만 초기 구상이다.

![image](https://user-images.githubusercontent.com/90199652/198581788-0f14796a-0272-4a61-be72-a1ad75b90622.png)
![image](https://user-images.githubusercontent.com/90199652/198581802-2de2c70d-e973-43c5-b0d1-3c70b5dd6484.png)
![image](https://user-images.githubusercontent.com/90199652/198581842-e85798cf-e10f-4f7f-8710-b9d918bcb015.png)
![image](https://user-images.githubusercontent.com/90199652/198581877-8fc124f1-02a8-4222-8c1f-62832ba74a30.png)
![image](https://user-images.githubusercontent.com/90199652/198581906-2d7ab7b8-9bc5-4df9-b2b8-e1362a36f4d4.png)


