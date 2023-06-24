using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Serialization
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public class TinyJsonDeserializer
	{
		// Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x706EF0", Offset = "0x7054F0", VA = "0x180706EF0")]
		public static object Deserialize(string text, Type type, [Optional] object populate, [Optional] GameObject contextRoot)
		{
			return null;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x7070D0", Offset = "0x7056D0", VA = "0x1807070D0")]
		private object Deserialize(Type tp, [Optional] object populate)
		{
			return null;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x708160", Offset = "0x706760", VA = "0x180708160")]
		private UnityEngine.Object DeserializeUnityObject()
		{
			return null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x7081E0", Offset = "0x7067E0", VA = "0x1807081E0")]
		private UnityEngine.Object DeserializeUnityObjectInner()
		{
			return null;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x7089D0", Offset = "0x706FD0", VA = "0x1807089D0")]
		private void EatWhitespace()
		{
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x708A70", Offset = "0x707070", VA = "0x180708A70")]
		private void Eat(string s)
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x708C80", Offset = "0x707280", VA = "0x180708C80")]
		private string EatUntil(string c, bool inString)
		{
			return null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00006314 File Offset: 0x00004514
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x708E60", Offset = "0x707460", VA = "0x180708E60")]
		private bool TryEat(char c)
		{
			return default(bool);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x708EE0", Offset = "0x7074E0", VA = "0x180708EE0")]
		private string EatField()
		{
			return null;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x708F70", Offset = "0x707570", VA = "0x180708F70")]
		private void SkipFieldData()
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x7090D0", Offset = "0x7076D0", VA = "0x1807090D0")]
		public TinyJsonDeserializer()
		{
		}

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextReader reader;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject contextRoot;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NumberFormatInfo numberFormat;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder builder;
	}
}
