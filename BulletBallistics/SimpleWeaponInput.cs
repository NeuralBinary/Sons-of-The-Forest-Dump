using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class SimpleWeaponInput : MonoBehaviour
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x90D290", Offset = "0x90B890", VA = "0x18090D290")]
		private void Awake()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x90D3C0", Offset = "0x90B9C0", VA = "0x18090D3C0")]
		private void Update()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x90D480", Offset = "0x90BA80", VA = "0x18090D480")]
		public SimpleWeaponInput()
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x20")]
		public Weapon myWeapon;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x28")]
		public string FireButtonName;
	}
}
