using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Input
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[AddComponentMenu("Sons/Input/InputCursorState")]
	public class InputCursorState : MonoBehaviour
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x30632F0", Offset = "0x30618F0", VA = "0x1830632F0")]
		public static List<InputCursorState> GetInstances()
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3063340", Offset = "0x3061940", VA = "0x183063340")]
		public static bool ActiveEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3063460", Offset = "0x3061A60", VA = "0x183063460")]
		public static bool ActiveHardwareCursor()
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
		internal bool Enabled()
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		internal int GetPriority()
		{
			return 0;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x25729C0", Offset = "0x2570FC0", VA = "0x1825729C0")]
		internal bool HardwareCursor()
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3063580", Offset = "0x3061B80", VA = "0x183063580")]
		private void OnEnable()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3063810", Offset = "0x3061E10", VA = "0x183063810")]
		private void OnDisable()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3063990", Offset = "0x3061F90", VA = "0x183063990")]
		private void RefreshState()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3063D30", Offset = "0x3062330", VA = "0x183063D30")]
		private static InputCursorState GetFirstValid(bool removeNulls = true)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3063F20", Offset = "0x3062520", VA = "0x183063F20")]
		private void Clear()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3064050", Offset = "0x3062650", VA = "0x183064050")]
		private void Apply(InputCursorState instance)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public InputCursorState()
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _priority;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _enabled;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _hardwareCursor;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<InputCursorState> Instances;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x8")]
		private static InputCursorState _active;
	}
}
