// <네임스페이스>
// 내부 식별자(형식, 함수, 변수 등의 이름)에 범위를 제공하는 선언적 영역
// 같은 이름의 식별자라 하더라도 다른 네임스페이스에 있다면 다른 클래스로 인식
// 여러 라이브러리가 포함된 경우, 협업하는 과정에서 네이밍룰 등으로 이름 충돌을 방지하는데 사용

using ACompany;     // 이 파일의 이후 코드부터 네임스페이스에서 정의된 식별자를 사용
// using BCompany;
using CCompany;
using DCompany;

namespace _08._OOP_p
{
    internal class NameSpace
    {
        void Func()
        {
            AClass nameA = new AClass();                // using 을 통해 네임스페이스를 사용하는 경우 식별자 생략가능
            // BClass nameB = new BClass();             // error : 네임스페이스의 식별자 없이 클래스를 가져오기 불가 (보통의 경우 C# 자동완성으로 using 추가)

            // 네임스페이스를 식별자로 같은 이름의 클래스도 구분하여 사용가능
            CCompany.SameClass nameC = new CCompany.SameClass();
            DCompany.SameClass nameD = new DCompany.SameClass();
            // SameClass sameName = new SameClass();    // error : 모호한 참조 (CCompany, DCompany 둘 모두 같은 이름의 클래스 사용)
        }
    }
}

namespace ACompany
{
    public class AClass { }
}

namespace BCompany
{
    public class BClass { }
}

// 네임스페이스가 구분된 경우 동일한 클래스 이름이 있지만 충돌하지 않음
namespace CCompany
{
    public class SameClass { }
}

namespace DCompany
{
    public class SameClass { }
}