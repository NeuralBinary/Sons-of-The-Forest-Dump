using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public class ObjectRegister : MonoBehaviour
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA87A30", Offset = "0xA86030", VA = "0x180A87A30")]
		private void Awake()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xA87BA0", Offset = "0xA861A0", VA = "0x180A87BA0")]
		private void OnValidate()
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x60001BE")]
		public static bool TryFind<T>(string id, out T result) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA87CF0", Offset = "0xA862F0", VA = "0x180A87CF0")]
		private static void Register(ObjectRegister item, UnityEngine.Object target)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA881C0", Offset = "0xA867C0", VA = "0x180A881C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA881C0", Offset = "0xA867C0", VA = "0x180A881C0")]
		private static void Unregister(ObjectRegister item)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObjectRegister()
		{
		}

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> _ids;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x8")]
		private static List<ObjectRegister> _keys;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x10")]
		private static List<WeakReference<UnityEngine.Object>> _objects;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _id;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEngine.Object _target;
	}
}
