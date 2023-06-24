using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public class HangingTacticalSync : MonoBehaviour
	{
		// Token: 0x060033A7 RID: 13223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x34BD810", Offset = "0x34BBE10", VA = "0x1834BD810")]
		public static List<string> ListForDropdown()
		{
			return null;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x34BD850", Offset = "0x34BBE50", VA = "0x1834BD850")]
		public void HangingTacticalCutDown()
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x34BD8D0", Offset = "0x34BBED0", VA = "0x1834BD8D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x34BDA10", Offset = "0x34BC010", VA = "0x1834BDA10")]
		private void OnDisable()
		{
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x34BDAA0", Offset = "0x34BC0A0", VA = "0x1834BDAA0")]
		private void OnNamedIntDataChanged(NamedIntData data)
		{
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x34BDAD0", Offset = "0x34BC0D0", VA = "0x1834BDAD0")]
		private void SetStateValue(HangingTacticalState state)
		{
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AD")]
		[Address(RVA = "0x2F85160", Offset = "0x2F83760", VA = "0x182F85160")]
		public void DoCutDown()
		{
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033AE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HangingTacticalSync()
		{
		}

		// Token: 0x04002CB5 RID: 11445
		[Token(Token = "0x4002CB5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _namedIntKey;

		// Token: 0x04002CB6 RID: 11446
		[Token(Token = "0x4002CB6")]
		[FieldOffset(Offset = "0x28")]
		private NamedIntData _namedIntData;

		// Token: 0x04002CB7 RID: 11447
		[Token(Token = "0x4002CB7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onCutRopeEvent;
	}
}
