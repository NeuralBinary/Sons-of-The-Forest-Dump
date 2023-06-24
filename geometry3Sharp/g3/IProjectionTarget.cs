using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public interface IProjectionTarget
	{
		// Token: 0x06001E28 RID: 7720
		[Token(Token = "0x6001E28")]
		Vector3d Project(Vector3d vPoint, int identifier = -1);
	}
}
