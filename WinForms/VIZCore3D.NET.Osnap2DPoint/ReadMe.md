# VIZCore3D.NET.Osnap2DPoint

VIZCore3D.NET.Osnap2DPoint는 VIZCore3D.NET 라이브러리를 활용하여 3D 모델 뷰어에서 2D 화면상의 마우스 위치에 대한 OSNAP(객체 스냅) 3D 좌표를 획득하는 기능을 제공하는 Windows Forms 샘플 애플리케이션입니다.

## 🧩 주요 기능

- **2D 마우스 위치 기반 3D 좌표 획득**  
  사용자가 3D 뷰어에서 마우스를 이동하거나 클릭할 때, 해당 2D 위치에 대응하는 3D 모델상의 OSNAP 좌표(예: Vertex, Edge, Face 등)를 실시간으로 계산하여 제공합니다.

- **VIZCore3D.NET 통합**  
  VIZCore3D.NET 컨트롤을 폼에 임베드하여 3D 모델 로딩, 시각화, 상호작용 기능을 지원합니다.

- **간단한 UI**  
  직관적인 Windows Forms UI로 OSNAP 2D-3D 변환 기능을 쉽게 테스트할 수 있습니다.

## ⚙️ 시스템 요구 사항

- **.NET Framework**: 4.0 이상
- **VIZCore3D.NET 라이브러리**: 별도 설치 필요

## 🚀 사용 방법

1. 프로그램 실행 후 3D 모델을 로드합니다.
2. 3D 뷰어에서 마우스를 이동하거나 클릭하면, 해당 2D 위치에 대한 3D OSNAP 좌표가 화면에 표시됩니다.
3. 다양한 OSNAP 타입(점, 선, 면 등)에 대한 좌표를 확인할 수 있습니다.

