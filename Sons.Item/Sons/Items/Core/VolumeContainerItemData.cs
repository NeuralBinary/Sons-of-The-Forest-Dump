using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	[CreateAssetMenu(fileName = "VolumeContainerItemData", menuName = "Sons/Data/Items/Modules/VolumeContainerItemData", order = 0)]
	public class VolumeContainerItemData : ScriptableObject
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public VolumeContainerItemData()
		{
		}

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		[Min(0f)]
		public float TotalVolume;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x1C")]
		[Min(0f)]
		public float StartingVolume;
	}
}
