using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Anim
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	[AddComponentMenu("Sons/Construction/HierarchyGameObjectReceiver")]
	public class HierarchyGameObjectReceiver : MonoBehaviour, IHierarchyGameObjectReceiver
	{
		// Token: 0x06001501 RID: 5377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x2DF9D70", Offset = "0x2DF8370", VA = "0x182DF9D70", Slot = "4")]
		public void Register(IHierarchyGameObject hierarchyGameObject)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x2DF9E30", Offset = "0x2DF8430", VA = "0x182DF9E30", Slot = "5")]
		public void Unregister(IHierarchyGameObject hierarchyGameObject)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0000C134 File Offset: 0x0000A334
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x2DF9EB0", Offset = "0x2DF84B0", VA = "0x182DF9EB0")]
		public bool TryGetGameObject(GameObjectIdentifier identifier, out GameObject go)
		{
			return default(bool);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x2DF9F20", Offset = "0x2DF8520", VA = "0x182DF9F20")]
		public HierarchyGameObjectReceiver()
		{
		}

		// Token: 0x04000A6E RID: 2670
		[Token(Token = "0x4000A6E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<GameObjectIdentifier, GameObject> _registeredGOs;
	}
}
