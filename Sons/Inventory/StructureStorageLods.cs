using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Utils;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Inventory
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	public class StructureStorageLods : DistanceActivationBase
	{
		// Token: 0x06002951 RID: 10577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x33EB150", Offset = "0x33E9750", VA = "0x1833EB150", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x33EB180", Offset = "0x33E9780", VA = "0x1833EB180", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x33EB300", Offset = "0x33E9900", VA = "0x1833EB300", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x33EB480", Offset = "0x33E9A80", VA = "0x1833EB480")]
		public StructureStorageLods()
		{
		}

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("_gameObjects")]
		[SerializeField]
		private List<GameObject> _lodObjectsToToggle;
	}
}
