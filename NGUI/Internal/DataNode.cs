using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace NGUI.Internal
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	public class DataNode
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E6")]
		public Type type
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x26636F0", Offset = "0x2661CF0", VA = "0x1826636F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2663770", Offset = "0x2661D70", VA = "0x182663770")]
		public object Get(Type type)
		{
			return null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000384")]
		public T Get<T>()
		{
			return null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x26637D0", Offset = "0x2661DD0", VA = "0x1826637D0")]
		public DataNode AddChild()
		{
			return null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x2663930", Offset = "0x2661F30", VA = "0x182663930")]
		public DataNode AddChild(string name)
		{
			return null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x26639A0", Offset = "0x2661FA0", VA = "0x1826639A0")]
		public DataNode AddChild(string name, object value)
		{
			return null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x2663AF0", Offset = "0x26620F0", VA = "0x182663AF0")]
		public DataNode SetChild(string name, object value)
		{
			return null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2663C60", Offset = "0x2662260", VA = "0x182663C60")]
		public DataNode GetChild(string name)
		{
			return null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038A")]
		public T GetChild<T>(string name)
		{
			return null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038B")]
		public T GetChild<T>(string name, T defaultValue)
		{
			return null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x2663D70", Offset = "0x2662370", VA = "0x182663D70")]
		public void Write(StreamWriter writer)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2663D80", Offset = "0x2662380", VA = "0x182663D80")]
		public void Read(StreamReader reader)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2663E40", Offset = "0x2662440", VA = "0x182663E40")]
		public void Clear()
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2663EF0", Offset = "0x26624F0", VA = "0x182663EF0")]
		private string GetValueDataString()
		{
			return null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2664770", Offset = "0x2662D70", VA = "0x182664770")]
		private string GetValueString()
		{
			return null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2664A10", Offset = "0x2663010", VA = "0x182664A10")]
		private bool SetValue(string text, Type type, string[] parts)
		{
			return default(bool);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x26664E0", Offset = "0x2664AE0", VA = "0x1826664E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2666530", Offset = "0x2664B30", VA = "0x182666530")]
		private void Write(ref string data, int tab)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x26668A0", Offset = "0x2664EA0", VA = "0x1826668A0")]
		private void Write(StreamWriter writer, int tab)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2666B10", Offset = "0x2665110", VA = "0x182666B10")]
		private string Read(StreamReader reader, string line, ref int offset)
		{
			return null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2666C30", Offset = "0x2665230", VA = "0x182666C30")]
		private bool Set(string line, int offset)
		{
			return default(bool);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x26670F0", Offset = "0x26656F0", VA = "0x1826670F0")]
		private static string GetNextLine(StreamReader reader)
		{
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x26671B0", Offset = "0x26657B0", VA = "0x1826671B0")]
		private static int CalculateTabs(string line)
		{
			return 0;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2667200", Offset = "0x2665800", VA = "0x182667200")]
		private static string Escape(string val)
		{
			return null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x26672A0", Offset = "0x26658A0", VA = "0x1826672A0")]
		private static string Unescape(string val)
		{
			return null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2667340", Offset = "0x2665940", VA = "0x182667340")]
		private static Type NameToType(string name)
		{
			return null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x26677E0", Offset = "0x2665DE0", VA = "0x1826677E0")]
		private static string TypeToName(Type type)
		{
			return null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x26679C0", Offset = "0x2665FC0", VA = "0x1826679C0")]
		private static object ConvertValue(object value, Type type)
		{
			return null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2667C90", Offset = "0x2666290", VA = "0x182667C90")]
		public DataNode()
		{
		}

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		public object value;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x20")]
		public List<DataNode> children;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x0")]
		private static object[] mInvokeParams;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Type> mNameToType;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, string> mTypeToName;
	}
}
