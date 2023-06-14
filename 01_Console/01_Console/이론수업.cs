﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Console
{
    class 이론수업
    {

        /*5월 18일
         * 가장 먼저 해야할 것. 1. 게임 사전기획  : 무엇을 만들지 구체화, 정확하게 머릿속에있는 그림을 다른사람에게 전달하기 위함. 만약 팀프로젝트라면 의견조율 필요

         * 2. 분석 : 이게 맞나? 최선인가? // 시장상황 유사 출시 게임작 시장점유율 등을 고려해야함., 차별점 유사한 시장에 존재하는게임 중 굳이 내가만든 게임을 해야하는 이유가 있는가?
                     현실적인 문제로 상업적인 가치가 있는가? 결국 게임을 만드는 이유는 돈을 벌기 위함. 회사입장에서 고려해야할것 임금, 엔진 로열티, 
           3. 평가 :  디테일한 객관적 평가 
           4. 발전 : 아이디어를 강화하고 발전시키기 : DLC, 
           5. 최종결정 : 

         *  DLC mode 추가
         * @@ reverse 접근방식 : 문제점이 있는 곳을 먼저 찾는다.
         * 
         * 기획
         * - 무엇을 만들것인가 -> 아이디어의 발상
         * 영감 - 번뜩이는 아이디어 
         * 브레인스토밍 기법 : 우선 아이디어를 생각나는대로 쏟아내고, 꺼내고본다, 이 단계에서는 태클금지
         * 
         *  공명 : 아이디어를 정리하고 합친다. 시너지 작용이 일어날수 있는 경우의 수를 파악한다.
         * 
         * 수렴 :불필요한 곁가지 아이디어를 쳐낸다. (한줄로, 가능하면 짧게 정리가능해야한다.)
         * 
         * 
         * 5월 19일 ------------------
         * 분석 : 시장분석, 사용자, 경쟁자 (어디서, 어느시장에서 무엇을 할 것인가)
         * 시장분석  - 게임시장의 특징 : 온라인마켓 위주의 유통구조, 아이디어기반의 창조가 비교적 자유롭다. 
         *            사회적 분위기 확인 , 정책 및 법률 (ex 셧다운제) 개인의 사적으로 선을 넘는 행위는 비교적 관대하나, 집단, 회사 의 선을 넘는 행위는 그렇지 못하다.
         *  
         *  사용자 - 타겟층 분석 : 나이, 성별, 직업군 직장인target의 방치형 게임, 대체적으로 남자 -액션류, 여자- 키우기 
         *  
         *  경쟁자분석 - 상대방의 장단점 분석, 장점을copy하고 단점을 보완한다
         *  정보획득 - 직접 플레이  or 검증 필요 or 신뢰성있는 공식자료 // 
         *  중요한 정보의 판별 (KPI Key Perfomence indicator) 게임백서
         *       
         *       
         *       
         *  5월 22일 (월)----------------------------
         *  KPI - 게임의 성공여부를 판단하는데 사용되는 지표
         *  감정과 감성을 배제한 냉정하고 객관적 평가. 불가피하게 숫자로 판단할 수 밖에 없다.
         *  
         *  매출, 다운로드 횟수, DAU, MAU, 전환률
         *  
         *  
         *  비즈니스 모델
         *  ex) 오락실, 패키지 구매, 월정액, 부분무료화 free to Play, 확장팩 발매, DLC,
         *        
         *  
         *  다운로드 횟수/ free to Play 유료컨텐츠를 일부 맛을 보게 한 다음 현질유도  / 전환율 = 전체 플레이 유저 / 실제 비용을 지불한 경우 ; 
         *  어쩔수없이 적절한 현질유도가 필요하다.
         *  
         *  DAU, MAU 
         *  
         *  -매출이 커질수록 순이익률이 올라갈 확률도 높아진다. 순이익 
         *  
         *  게임회사 - 대부분 영세하다. 구조적으로 투자자를 끼고 가는 경우가 많다. 투자자의 입김이 많이 작용하면 때때로 방향성이 어긋나는 경우가 있다.
         *  투자자는 대체적으로 보수적이다.
         *  
         *  
         *  5월 23일 (화)---------------------------------------------------------
         *  평가 
         *  게임 기본 구성요소
         *  스토리, 캐릭터
         *  포괄적인 개념으로 메커니즘 : 규칙
         *  미적요소 : 그래픽, 사운드, 스토리 케릭터    
         *  기술 : 몰입이 깨지는 순간 재미가 없다고 느끼게 된다. 가장 몰입을 깨는순간 - 버그로인해 서버가 터졌을때   프로그래머와 그래픽디자이너의 목적이 상충할 때가 종종 있다.
         *  게임공간 : 맵 , 기획자입장에서 오픈월드게임을 만들때 가장 힘든것 유기적으로 스토리를 연결하는것. 유저가 어디로 갈지 모르기 때문.  좋은예로 젤다가 있다.
         *  차별화요소 : 굳이 이 게임을 해야할 이유,   포지셔닝이 이미 잘 되어있는 경우, 그래픽 , 사운드
         *  게임 재미요소 : 성취감 - 적절한 허들, 보상 제공 : 현실과 대비되는 점이고, 게임이 재밌는 이유이다. 불확실성도 여기에 포함된다.
         *                 욕구충족 - 매슬로우  심리적욕구, 안전의 욕구, 사회적 욕구 - 길드, 커뮤니티, 동호회,    존경의 욕구 - 랭킹 시스템, 자아실현 - 자신만의 목표
         *                 자극적인 요소 : 평소에 하지 못하는 것들
         *                 감정 이입 :
         *                 의미있는 선택 제공(리스크에 따른 선택) : 선택에 따른 다른 스토리 전개 
         *                  단계적 매몰비용 발생시키기
         *  5월 24일 수 -----------------------------------------------------------------------
         *  보상. 100%만족감을 주면 흥미를 잃게 된다. 주기적으로 갈증을 느끼게 만드는 구조가 회사입장에선 불가피하다.
         *  경쟁사에서 내가 생각하는 차별화 요소를 제공하는가?  사용할때, 하지 않을때 그 이유를 분석
         *  실현가능성
         *  게임 세션 길이 - 게임 을 플레이할 때 한판의 길이, 스테이지 단위, 사람의 집중력은 한계가 있다. 뇌가 refresh 하는 시간
         *  
         *  레벨디자인 - 맵을 어떨게 꾸밀 것인가?  ,오브젝트, NPC등의 위치를 유기적으로 배치해야한다.
         *              선형구조(고전적 방식 ), 평면구조(오픈월드 방식)
         *              
         *  자원 - 경제시스템, 화폐(경화 hard currency 조절가능 cash, 연화softCurrency 제작자 입장에서 Control 불가능 유저가 원하는 만큼 획득할 수 있다.
         *                                                          인플레 가능성 존재 - 돈을 소비하게끔 만드는 시스템이 필요
         *         아이템
         *         자원은 병목구간이 필요하다. - 자원이 부족해지는 구간이 필요하다. (현질유도)
         *         
         *  벨런스 - 대칭구조(벨런스 적으로는 가장 완벽하지만 게임이 변수가 없고, 뻔하고, 단조로워진다.)
         *           비대칭적으로 하면서 밸런스를 맞추기란 쉬운일 이 아니다.
         *        -  우월전략을 발생시키면 안된다. (무조건 유리한 전략) 항상 같은패턴이 반복되게 된다.
         *        - 학습곡선을 고려해야한다. 게임을 배우는데 어려워선 안된다.  배우기는 쉽고 마스터하기는 어렵게 만들어야한다.
         *        
         *  비즈니스모델 - 돈을 버는 방법. 어떻게 수익을 창출할 것인가. 대표적모텔 free to play 부분 유료화, 패키지, DLC, 가챠, P2E play to earn(NFT),
         *  
         *  실현가능성
         *  - 기술적 : 게임내 기능을 실제로 구현 가능한가?
         *  - 상업적 : 게임 발매로 수익을 낼 수 있는가
         *  
         *  아이디어 강화 및 발전
         *  -극적 효과 강화 : 줄거리, 스토리, 주제, 테마, 매력적인 그래픽, 캐릭터, 배경,  감성을 자극하는 부분
         *  
         *  최종결정 및 정리
         *  - 소프트웨어 개발 모델     waterFall 방식 문제점 : 이전 작업에 수정할 것이 생기면 처음부터 갈아엎어야한다.
         *                           나선형 모델 (점진적 모델) :구현, 평가 반복 
         *                           프로토타이핑 모델 : 핵심기능만 구현을 해서 테스트 해본다
         *      
         *  - 문서화 
         *  
         *  
         *  5월 29일 --------------------------------------------------------------
         *  
         *  평가
         *  게임시장은 어떤 특성을 갖고있는가
         *  
         *  1-2 게임흥행여부를 판단하기 위한 KPI를 하나이상 나열하시오
         *      매출,순이익, DAU, MAU전환율
         *      
         *  2-1 게임산업에대한 공식적이고 객관적 정보를 얻기에 적합한 기관은?
         *  통계청, 한국콘텐츠 진흥원
         *  
         *  2-2 게임디자인시 고려할 인구통계 변인에는 어떤 것들이 있는가
         *  나이, 성별, 직업군,
         *  
         *  3-1 게임을 구성하는 네가지 기본요소는 무엇인가
         *  -메커니즘, 기술, 미적요소, 스토리, 게임공간
         *  
         *  3-2 게임이 제공하는 재미요소에는 어떤것들이 있는가
         *  욕구충족,몰입, 감정이입, 성취감 등
         *  
         *  4-1 많은 수의 아이디어를 쉽게 구상하기 위한 방법중 하나로 최대한 자유롭게 의견을 제ㅣ하는 것을 가장중요시 여기는 학습도구, 기법이 무엇인가
         *      브레인스토밍
         *  
         *  4-2 창조적발상을 위한 네가지 단계는 어떻게 되는가
         *      영감 - 종합 - 공명 - 수렴 
         *      
         *  5-1 플레이어의 게임숙련도를 학습량, 학습시간, 반응시간 정밀도등을 측도로 그래프로 나타낸것은?
         *      학습곡선
         *      
         *  5-2 게임 내 PVP 밸런스를 잡는방법 중 가장 쉬운방법은 무엇인가?
         *      -대칭이 되도록 양쪽을 똑같이 만든다.
         *  (Ran Ability) 비대칭
         *  
         *  6-1 여러아이디어의 각 요소와 부분을 적절히 배합해서 새로운 아이디어를 만들어내는 것을 무엇이라고 하는가
         *  합성, 공명
         *  
         *  6-2 게임의 극적 요소를 강화하기 위한 요소들에는 어떤 것들이 있는가
         *  장르 줄거리, 스토리, 그래픽
         *  
         *  
         *  
         *  
         *  
         *  
         *  6월 7일 평가 예정
         *  
         *  게임 컨셉기획
         *  
         *  장르 
         *  - 예술적 부분에서 작품을 구분할 때 느슨한, 분류 범위 / 들었을때 확실치는 않지만 대략적으로 유추가능한 범위 
         *  
         *  게임장르
         *  - 초기 : 하드웨어 스펙이 저렴했을 때는 제한적이었다.  액션, 퍼즐, 어드벤처, RPG, 전략
         *  
         *  - 이후 : 액션RPG, 대전액션 등 장르의 조합, 합성이 가능해졌다. 
         * 
         *  
         *  액션, 대전 조합의 스트리트파이터 커맨드 입력방식으로 히트를 쳤었다.
         *  
         *  RPG, Table RPG - 던전앤드래곤
         *  RPG 의 핵심은 플레이어의 성장이다.
         *  
         *  5월 30일 -----------------------------------------------------------------------
         *  
         *  게임의 주제, theme
         *  - 게임 디자인에서 게임의 메시지를 전달하기 위한 일정한 방향성을 이끌어내는 핵심요소, 전달하고싶은 말, 이야기, 스토리, 정체성
         *  - 플레이어가 자연스럽게 공감할 수 있도록 전달. 공감이 안되면 몰입이 깨지고, 왜 플레이를 해야하는지에 대한 의문이 들 수 밖에 없다.
         *  - 보편성 - 대체적으로 대중들은 비슷한 생각을 갖고있다., 일관성 - 어떤 이야기를 하고싶은 것인가, 의미, 흥미 등등...
         *  
         *  이야기(스토리)
         *  - 게임 스토리텔링의 가장 큰 특징. - 플레이어의 선택에 의해 게임의 내용이 변하는 상호작용. 인터렉티브하다.
         *  - 시나리오 : 과정중 상황이 바뀔 수 있기 때문에 처음부터 완벽하게 시나리오를 짤 수는 없다 
         *              => 시놉시스 : 전체적인 줄거리와 윤곽, 주제, 기획의도, 줄거리, 등장인물 등이 포함되어야 함 . 왜 이렇게 해야하는지 짧게 요약해야함. 투자유치를 위해 중요하다.
         *  
         *  시놉시스 이후 스토리보드 (3-1)
         *   - 이야기의 구성요소, 촬영정보, 동선등을 간략하게 장면별로 스케치한것
         *   
         *   서사
         *   - 이벤트를 순서대로 잘 전달하는 것.
         *    오픈월드형식에서는 쉽지 않다.
         *    플레이어 유도(간접통제) - 
         *    자의에 의한 선택이라고 느끼되 자연스러운 선택을 따라 스토리가 진행될 수 있도록 오브젝트를 배치 또는 BGM 변경 등으로
         *    
         *  
         *  5월 31일 -------------------------------------------------------------------------------
         *  
         *  캐릭터 
         *  - 캐릭터 수집형, 고유한 매력
         *    - 능력치
         *    - 외형
         *    - 캐릭터간 관계
         *    - 역할 - 악역, 중간보스 , 최종보스, 스승, 제자
         *    
         *    PC - playable character  
         *        아바타, 사용자의 분신
         *        커스터마이징 : 플레이어가 원하는 개성을 가질 수 있도록 외형을 변경하는 기능을 제공 - 플레이어의 몰입을 강화할 수 있다.
         *        불쾌한 골짜기?
         *        
         *    NPC - Non playable character - 
         *          플레이어를 제외한 모든 케릭터
         *          정보제공(스토리 전개, 튜토리얼, 조작방식), 컨텐츠 제공( 전투, 보상, 미니게임)
         *          
         *          적, 동료
         *          동료
         *          - 두번째 PlayableCharacter
         *          - 전투 보조 상호보완적으로 능력치 설계
         *          - 피보호자
         *          - 스토리 설명 
         *          플레이어는 사용자와 지식수준이 비슷할수록 감정이입에 원활하다. 
         *          
         *          
         *          적의 역할
         *          - 플레이어와 싸우는 대상
         *          - 싸우는 이유 - 전투 자체가 재밌을 경우, 게임의 진행, 성장, 보상, 죽이고싶은 적의 도발
         *          - 적과의 드라마 -> 인상깊은 적을 만들 수 있다. 빌드업과정이 너무 길면 인내심의 한계치를 넘어 게임을 접어버린다.        
         *  6월 1일 --------------------------------------------------------------------------
         *  Git hub
         *      
         *  6월 2일 --------------------------------------------------------------------------------------------------------------
         *  배경
         *      구성요소 : 미적 요소 (시대적 배경, 문화적 배경, 스토리, 음향(앞으로 일어날 이벤트를 미리 암시할수 있게 해준다))
         *      
         *      컨셉아트 : 게임을 만들기 전 머릿속에 있는 것을 타인에게 정확하게 전달하기 위해 시각화 한것. 컨텐츠의 아이디어 전개와 상황 연출을 보여주는것
         *      세계관 : 작품의 시공간적 배경 
         *      음향의 역할 : 주제 강조, 주변환경의 디테일 표현, 힌트 제공
         *      
         *      
         *  기술
         *      기술적 요소가 중요한 이유
         *      -기술이 부족할 경우 구상중인 컨셉을 제대로 원활하게 전달할 수 없다
         *      
         *  미리 만들어보기
         *      -프로토타입핑 : 게임을 실제로 제작하기 전에 정말 기능적으로 구현이 가능한지, 기술 실증과 재미를 확인하기 위한 핵심요소만 먼저 만드는 작업
         *      -그레이박스 레벨디자인 : 게임에서 실제사용할 아트워크를 만들기 전에 레벨 안에서의 크기와 레이아웃을 확이낳기 위해 회색의 상자로 대략적인 크기만 맞춰 작성하는 레벨디자인
         *      
         *  시점
         *      3인칭 : 제 3자 입장에서 플레이어를 살펴보는 카메라 시점 사이드뷰, 탑뷰, 쿼터뷰 등등
         *      1인칭 : 플레이어의 시점과 사용자의 시점을 일치시킨 카메라 시점
         *          
         *          
         *          
         *  6월 8일 ---------------------------------------------------------------------------------------------------------------
         *  게임 알고리즘(문제를 하결하는 방법)
         *      (디자인패턴)모범답안 보다 좀더 정답에 가까운 기준, 해결하기 위한 절차를 순서대로 설명한것 : 최대한 간결하게 필요한 내용만
         *      
         *      - 좌표계 - 위치를 표현하기 위한 시스템, 데카르트 좌표계
         *      
         *      좌표계를 표현하는 방법 - 왼손좌표계, 오른손좌표계(수학계에서 일반적으로 사용됨)
         *      
         *      왼손좌표계  (Window, Maya) - 오른쪽 : +x // 위쪽 +y // 앞쪽 +z
         *      
         *      
         *      오른손좌표계(OpenGL, 3D Max) 오른쪽 +x // 위쪽 +y // 뒤쪽 +z
         *      
         *      
         *      로컬좌표계 : 오브젝트의 원점을 기준으로 한 좌표계
         *      
         *      월드좌표 : 월드의 원점을 기준으로 한 좌표계
         *      
         *      월드변환(World Transform)
         *  
         *  6월 9일 ---------------------------------------------------------------------------------------------------
         *  
         *  월드변환(World Transform)
         *      오브젝트가 있다고 가정 - 저장된 데이터 : 구성하고있는 점들의 좌표, 그리는 순서, 겹쳐지는 점들의 번호 , 로컬좌표를 월드좌표로 변환하는 작업
         *      위 이련의 과정들은 계산량을 줄이기 위한 과정이다.
         *  
         *      스크린좌표계
         *      픽셀위 위치를 나타내기위한 좌표계, 원점기준,
         *      
         *      좌표계 - 원점과 축의 방향이 어떻게 진행되는가?
         *      
         *  벡터(Vector) - 방향과 크기 
         *      * 내적 - 두 벡터간 사이각구할때 사용, 외적 - 
         *  
         *  행렬(Matrix)
         *      트렌스폼(위치, 회전, 크기 변화)를 하나의 행렬로 표현가능
         *      행렬을 곱하는 것으로 변화를 누적시킬 수 있다.
         *      변화의 순서에 따라 결과값이 달라지기때문에  적용가능
         *      
         *  쿼터니언(Quaternion)
         *      회전을 기록하는 방식
         *      오일러앵글의 짐벌락 현상을 해결하기 위해 등장
         *      더 적은 메모리 요구와 거 적은 연산이 가능하다
         *      
         *  충돌처리 - 오브젝트의 원점의 
         *      콜라이더가 없을 경우 오브젝트를 기준으로 처리할경우 연산량이 너무 많아진다.
         *      
         *      
         *      
         *      랜더링 파이프라인
         *      - 3D 월드를 2D래스터 이미지로 변경하는 작업
         *      
         *      DX9 기준 
         *      1. 로컬 변환
         *      2. 월드 변환 - 저장된 로컬의 점들을 월드좌표로 옮긴다.
         *      3. 카메라변환 : 눈에 보여지는 부분만 랜더링 하기때문에 카메라변환을 한다.
         *      
         *      2D, 3D의 가장 큰 차이점 - 원근감  
         *      카메라의 시야 near Far 조정가능
         *      
         *      4. 프로젝션(투영변환)
         *      5.레스터라이즈rasterize 최종적으로 이미지를 만드는 작업
         *      
         *      위 다섯가지 과정 1~5까지 1프레임
         *      
         *  메모리할당
         *      운영체제에 요청해서 받아와야한다.
         *      느리다. 운영체제를 거친다. 필요한 만큼의 빈공간이 있는지 찾아야한다. -> 다른프로그램이 해당 메모리공간을 못쓰도록 Lock 해야한다.
         *      
         *  메모리풀(Memory Pool)
         *      게임전체적으로 사용될것으로 예상되는 최대 메모리량을 한번에 할당받는다.
         *      메모리할당이 필요하면 이미할당된 Pool에서 꺼내옴 필요없어지면 Pool로 되돌려보냄
         *      객체를 생성할때 급격한 프레임드롭이 없어지고 메모리 파편화(메모리 공간의 낭비)를 막을 수 있다.
         *      
         *  오브젝트 풀(Object Pool)
         *      게임에서 한번에 사용될 최대 오브젝트 갯수만큼 오브젝트를 미리 생성해서 풀을 만든다.
         *      생성된 오브젝트는 모두 비활성화시킨다.
         *      필요할 때 풀에서 꺼내온 후 활성화 시켜준다.
         *      사용후 비활성화 후 풀로 반환한다.
         *      
         *  자료구조(어렵다는 선입견이 있다)
         *      데이터를 (어떻게) 저장하는 방법 (편하게 사용하기 위해) 어떤식으로 저장을 해야 빠르고 편하게 쓸수 있는가
         *      
         *      -배열 [] array
         *          같은종류의 데이터를 한번에 여러개 갖고싶을 때 사용 
         *          데이터 사이에 빈공간이 없어야한다.  필요한 주소 == 배열시작주소 + 데이터크기 * 인덱스
         *          장점 : 랜덤 엑세스성능이 매우 뛰어나다 
         *          단점 : 배열 크기 변경작업이 매우 느리다. 삽입, 삭제 //
         *                 데이터사이에 유사시 사용할 수 있는 빈공간이 없어야하기 때문에 new 를 사용해서 새로 만들어야하기 때문에 동적할당이 불가능하다
         *          
         *      리스트(List)
         *          배열의 단점을 커버하기 위해 등장 
         *          노드 (데이터 + 링크) 를 데이터를 저장한다. 시작 노드를 Head, 마지막주소값은 Tail이라고 한다.
         *          장점 : 삽입, 삭제가 매우 빠르다.
         *          단점 : 링크를 통해서 데이터 위치를 찾기 때문에 무조건 순서대로 찾아야해서 랜덤엑세스 접근속도가 매우 느리다.
         *      
         *      
         *      스텍(쌓다)
         *          후입선출(Last in First Out, LIFO), 데이터를 넣을 때 Push, 꺼내올때 Pop,  가장 나중에 추가된 데이터 = Top
         *          어떤 긴급한 상황에서 빠르게 실행해야할때 
         *          함수의 처리방식 - 함수안에서 다른 함수를 호출할 경우 
         *          
         *      큐(Queue)
         *          FIFI(First In First Out 선입선출)
         *          순서대로 처리하기위한 용도   마지막 추가된 부분 : rear // 가장먼저 추가된 부분 Front  .//데이터를 넣을 때 Enqueue// 꺼낼 때 Dequeue
         *          
         *      위 네가지를 포괄한 개념을 선형 자료구조(Linear Data Struct) 라고 한다.
         *      
         *      6월 12일 --------------------------------------------------------------------------------------------------
         *      
         *      비트연산 
         *              & : 둘 다 1 이면 1, 아니면 0
         *              | : 둘 중 하나라도 1이면 1, 아니면 0
         *              
         *              1 1 0 0
         *              1 0 1 0
         *              
         *           &  1 0 0 0
         *           |  1 1 1 0
         *              
         *           & =  bit flag 논리 곱,  할때 사용
         *           | = 논리 합, 추가할 때
         *        
         *        shift 연산
         *      << 왼쪽     1101  << 2  = 110100 , 데이터가 넘칠경우 넘친부분 삭제  //  << 1 = * 2 의 효과와 같아진다
         *      >> 오른쪽   1101  >> 2 = 0011 //   / 2 와 같은 효과
         *      
         *      
         *      Frustum View
         *      카메라 뷰 영역 안쪽만 렌더링 한다.   사각절두체, 카메라가 촬영하는 영역
         *      
         *      
         *      폴리곤, 페이스 - 기본적으로 모든 3D 오브젝트는 삼각형으로 구현된다.
         *      정점 (Vertex) 삼각형을 이루는 점
         *      메시(Mesh) 하나의 모델을 이루는 페이스의 집합. 하나의 모델 오브젝트
         *      엣지(Edge) 정점 사이를 잇는 선
         *      
         *      점의 위치 U, V
         *      
         *      보간(Interpolation, Lerp)
         *          시작값과 마지막 값이 있을 때 시작부터 끝까지 걸리는 시간이 있을 때 중간값을 계산 하는 것 500km 5시간 걸릴 때   2시간을 갔다면 200km 만큼 왔다고 가정할 수 있다.
         *      키프레임 애니메이션의 중간값을 보간으로 처리할때 사용된다.
         *      
         *      애니메이션
         *          키프레임 애니메이션 : 키프레임만 저장하고 나머지 애니메이션 정보는 보간 정보로 만드는 기법
         *          
         *          본(Bone)애니메이션 : 모델링 내부에 보이지않는 뼈를 심는다. 뼈가 움직이면 뼈와 연결된 정점만 움직이는 기법 리깅이라고 부르기도 한다
         *                              각 뼈는 계층적으로 구성되어있다. 상위뼈가 움직이면 하위뼈들도 유기적으로 움직인다. (얼마나 영향을 받을 지 설정된 값만큼)
         *                              
         *          Skinned Mesh : 본애니메이션의 확장 관절부분 같은 곳을 피부가 늘어나는 것 처럼 메시의 형태를 변경해서 관절부위가 벌어진 것처럼 보이지 않게 하는 것
         *          
         *  6월 13일 ---------------------------------------------------------------------------------------------------------
         *     
         *     C# 변수의 유형
         *   
         *     값형식(value)  
         *          변수에 값이 직접저장되는 형식
         *          스텍 메모리에 저장
         *          작지만 빠르게 접근 가능
         *          struct로 만들어진다  대입시 깊은복사  원본과 같은 사본이 만들어진다.
         *          ex(몬스터 오브젝트 생성) 참조형식 사용시 모든 개체가 같은 변화의 영향을 받게 된다
         *          같은 값의 사본을 만들어야하기 때문에 실행속도가 느리다.
         *          
         *     참조형식(referrence)
         *          변수 데이터에 대한 참조가 저장되는형식 
         *          힙 (운영체제가 관리하는 전체 메모리)메모리에 저장 new 연산자 사용할때도 할당
         *          크지만 느리다
         *          Class로 만들어진다
         *          대입시 얕은 복사.
         *          주소만 넘겨주기때문에 실행속도가 빠르다.
         *          
         *      제네릭 - 변수 외 타입도 파라미터로 넘길수 있다
         *      boxing unboxing
         *      힙, 스텍 
         *      
         *      선형자료구조
         *      list, stack, queue, 배열     배열과 리스트는 상호보완적
         *      ArrayList
         *      
         *      비선형자료구조
         *      tree 
         *        -노드는 반드시 하나의부모를 가진다.
         *         노드는 0개 이상의 자식을 가진다.
         *         계층구조, 위, 아래가 있다.   부모, 자식관계
         *          root 
         *          leaf(터미널)
         *       
         *     
         *      
         * 6월 14일 ------------------------------------------------------------------------------------
         *           
         *   이진트리(Binary tree)
         *      노드가 최대 2개의 자식을 가지는 트리
         *      
         *    이진탐색트리(Binary Search tree)
         *      노드는 (최대 두 개) 까지만 자식을 가질 수 있다.
         *      노드는 키 값을 가진다.
         *      키값은 순서가 있는 데이터 이어야 한다.
         *      키값은 유니크한 것이 좋다
         *      모든 노드에 대해서 키값이 작은 것은 왼쪽에 있고 키값이 큰 것은 오른 쪽에 있다.(빨리 찾기 위함)
         *      
         *    균형트리 (Balanced tree) - 순서를 잘못배정하면 그냥 리스트와 탐색 속도가 별 차이가 없어지는 단점을 보완하기 위해 고안해낸 것 
         *    
         *    Heap - 
         *    -트리구조를 갖고있는 자료구조 
         *    - 완전 이진트리의 (Complete)구조여야한다
         *    - 우선순위를 판별하는데 유리하다
         *          749325618
         *    - 최대힙과Max   - 부모는 자식보다 커야한다.
         *    - 최소힙Min   - 부모는 자식보다 작아야한다
         *                              
         *                              MIN heap
         *                                  1
         *                        2                      5   
         *                 3           4            9       6
         *             7       8
         *
         *      그래프
         *           지하철 노선도 같은 느낌
         *             -계층구조없음
         *- n:n 구조
         * - 길찾기 알고리즘에 자주 사용된다
         * 비선형 자료구조 - 그래프, 트리
         * 선형자료구조 - 리스트, 스텍, 큐, 배열
         *
         *
         *
         *
         *  
         *  
        */



    }
}
