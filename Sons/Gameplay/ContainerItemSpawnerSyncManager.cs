using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public class ContainerItemSpawnerSyncManager : MonoBehaviour
	{
		// Token: 0x060032C3 RID: 12995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C3")]
		[Address(RVA = "0x34AA5D0", Offset = "0x34A8BD0", VA = "0x1834AA5D0")]
		private void FindUnmanagedMarkers()
		{
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C4")]
		[Address(RVA = "0x34AA880", Offset = "0x34A8E80", VA = "0x1834AA880")]
		private void PushUnmanagedToManaged()
		{
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x34AAEE0", Offset = "0x34A94E0", VA = "0x1834AAEE0")]
		public ContainerItemSpawnerSyncManager()
		{
		}

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ContainerItemSpawner> _containers;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ContainerItemSpawner> _unmanagedContainers;
	}
}
