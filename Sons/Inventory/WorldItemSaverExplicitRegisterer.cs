using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000648 RID: 1608
	[Token(Token = "0x2000648")]
	public class WorldItemSaverExplicitRegisterer : MonoBehaviour
	{
		// Token: 0x060029A9 RID: 10665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x33EF860", Offset = "0x33EDE60", VA = "0x1833EF860")]
		private void Awake()
		{
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x33EFA40", Offset = "0x33EE040", VA = "0x1833EFA40")]
		public WorldItemSaverExplicitRegisterer()
		{
		}

		// Token: 0x04002510 RID: 9488
		[Token(Token = "0x4002510")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<WorldItemSaver> _worldItemSavers;

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x4002511")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _autoFindInScene;
	}
}
