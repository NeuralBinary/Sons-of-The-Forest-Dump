using System;
using Construction;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public interface IVisualLogInstanceProvider
	{
		// Token: 0x06000293 RID: 659
		[Token(Token = "0x6000293")]
		Vector3 GetLogSize();

		// Token: 0x06000294 RID: 660
		[Token(Token = "0x6000294")]
		float ConvertLogScale(ElementProfile foundationArchetypePilarElement, float scale);

		// Token: 0x06000295 RID: 661
		[Token(Token = "0x6000295")]
		GameObject SpawnLog(Vector3 pos, Quaternion rotation, Transform parent);

		// Token: 0x06000296 RID: 662
		[Token(Token = "0x6000296")]
		void DespawnLog(GameObject logInstance);

		// Token: 0x06000297 RID: 663
		[Token(Token = "0x6000297")]
		GameObject SpawnLogPlank(Vector3 pos, Quaternion rotation, Transform parent);

		// Token: 0x06000298 RID: 664
		[Token(Token = "0x6000298")]
		void DespawnLogPlank(GameObject logPlankInstance);
	}
}
