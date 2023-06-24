using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Serialization
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public class TinyJsonSerializer
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x704F10", Offset = "0x703510", VA = "0x180704F10")]
		public static void Serialize(object obj, StringBuilder output)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x704FD0", Offset = "0x7035D0", VA = "0x180704FD0")]
		private TinyJsonSerializer()
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x705930", Offset = "0x703F30", VA = "0x180705930")]
		private void Serialize(object obj)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x705EF0", Offset = "0x7044F0", VA = "0x180705EF0")]
		private void QuotedField(string name, string contents)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x705F60", Offset = "0x704560", VA = "0x180705F60")]
		private void SerializeUnityObject(UnityEngine.Object obj)
		{
		}

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x10")]
		private StringBuilder output;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, Action<object>> serializers;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CultureInfo invariantCulture;
	}
}
