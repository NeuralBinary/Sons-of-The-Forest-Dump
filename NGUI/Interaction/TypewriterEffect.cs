using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[AddComponentMenu("NGUI/Interaction/Typewriter Effect")]
	[RequireComponent(typeof(UILabel))]
	public class TypewriterEffect : MonoBehaviour
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x17000142")]
		public bool isActive
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x213CBB0", Offset = "0x213B1B0", VA = "0x18213CBB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x26A8010", Offset = "0x26A6610", VA = "0x1826A8010")]
		public void ResetToBeginning()
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x26A8040", Offset = "0x26A6640", VA = "0x1826A8040")]
		public void Finish()
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x26A82A0", Offset = "0x26A68A0", VA = "0x1826A82A0")]
		private void OnEnable()
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x26A82B0", Offset = "0x26A68B0", VA = "0x1826A82B0")]
		private void Update()
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x26A90F0", Offset = "0x26A76F0", VA = "0x1826A90F0")]
		public TypewriterEffect()
		{
		}

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x0")]
		public static TypewriterEffect current;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x20")]
		public int charsPerSecond;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x24")]
		public float fadeInTime;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x28")]
		public float delayOnPeriod;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x2C")]
		public float delayOnNewLine;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView scrollView;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x38")]
		public bool keepFullDimensions;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x40")]
		public List<EventDelegate> onFinished;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x48")]
		private UILabel mLabel;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x50")]
		private string mFullText;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x58")]
		private int mCurrentOffset;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x5C")]
		private float mNextChar;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x60")]
		private bool mReset;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x61")]
		private bool mActive;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x68")]
		private BetterList<TypewriterEffect.FadeEntry> mFade;

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		private struct FadeEntry
		{
			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x40003F7")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x040003F8 RID: 1016
			[Token(Token = "0x40003F8")]
			[FieldOffset(Offset = "0x8")]
			public string text;

			// Token: 0x040003F9 RID: 1017
			[Token(Token = "0x40003F9")]
			[FieldOffset(Offset = "0x10")]
			public float alpha;
		}
	}
}
