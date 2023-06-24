using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase
	{
		// Token: 0x060000CB RID: 203 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA3C840", Offset = "0xA3AE40", VA = "0x180A3C840")]
		protected List<GameObject> GetCurrentPathObjects()
		{
			return null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA3CAA0", Offset = "0xA3B0A0", VA = "0x180A3CAA0", Slot = "9")]
		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA3CB80", Offset = "0xA3B180", VA = "0x180A3CB80")]
		protected LightningBoltPathScriptBase()
		{
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x1F0")]
		[Tooltip("The game objects to follow for the lightning path")]
		[Header("Lightning Path Properties")]
		public List<GameObject> LightningPath;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x1F8")]
		private readonly List<GameObject> currentPathObjects;
	}
}
