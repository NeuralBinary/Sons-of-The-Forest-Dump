using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	public interface IOrientedProjectionTarget : IProjectionTarget
	{
		// Token: 0x06001E29 RID: 7721
		[Token(Token = "0x6001E29")]
		Vector3d Project(Vector3d vPoint, out Vector3d vProjectNormal, int identifier = -1);
	}
}
