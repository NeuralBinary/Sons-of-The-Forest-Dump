using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	[AddComponentMenu("Sons/Construction/DefensiveWallGateControl")]
	public class DefensiveWallGateControl : MonoBehaviour
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000299")]
		public DefensiveWallGateStructure Gate
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00006ADC File Offset: 0x00004CDC
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029A")]
		public DefensiveWallGateControl.States State
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return DefensiveWallGateControl.States.Idle;
			}
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[Token(Token = "0x1700029B")]
		public bool IsOpen
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x2E93060", Offset = "0x2E91660", VA = "0x182E93060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x2E93120", Offset = "0x2E91720", VA = "0x182E93120")]
		public void SetGate(DefensiveWallGateStructure gate)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x2E931C0", Offset = "0x2E917C0", VA = "0x182E931C0")]
		public void OpenGate()
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x2E932C0", Offset = "0x2E918C0", VA = "0x182E932C0")]
		public void CloseGate()
		{
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x2E93450", Offset = "0x2E91A50", VA = "0x182E93450")]
		private IEnumerator ToggleGateRoutine(bool openGate)
		{
			return null;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DefensiveWallGateControl()
		{
		}

		// Token: 0x02000158 RID: 344
		[Token(Token = "0x2000158")]
		public enum States
		{
			// Token: 0x040006A2 RID: 1698
			[Token(Token = "0x40006A2")]
			Idle,
			// Token: 0x040006A3 RID: 1699
			[Token(Token = "0x40006A3")]
			IsOpening,
			// Token: 0x040006A4 RID: 1700
			[Token(Token = "0x40006A4")]
			IsClosing
		}
	}
}
