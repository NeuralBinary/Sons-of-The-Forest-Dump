using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Save
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Sons/Save/AutoSaveGameRegistration")]
	public class AutoSaveGameRegistration : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3128CE0", Offset = "0x31272E0", VA = "0x183128CE0")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3128EF0", Offset = "0x31274F0", VA = "0x183128EF0")]
		public AutoSaveGameRegistration()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MonoBehaviour> _componentsToSave;
	}
}
