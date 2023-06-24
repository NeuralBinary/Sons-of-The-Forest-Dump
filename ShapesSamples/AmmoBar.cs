using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class AmmoBar : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2A57550", Offset = "0x2A55B50", VA = "0x182A57550")]
		private Vector2 GetBulletEjectPos(Vector2 origin, float t)
		{
			return default(Vector2);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000001")]
		public bool HasBulletsLeft
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2A57660", Offset = "0x2A55C60", VA = "0x182A57660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2A57670", Offset = "0x2A55C70", VA = "0x182A57670")]
		public void Fire()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2A576F0", Offset = "0x2A55CF0", VA = "0x182A576F0")]
		public void Reload()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2A57700", Offset = "0x2A55D00", VA = "0x182A57700")]
		private void Awake()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2A57790", Offset = "0x2A55D90", VA = "0x182A57790")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A57CD0", Offset = "0x2A562D0", VA = "0x182A57CD0")]
		public AmmoBar()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public int totalBullets;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		public int bullets;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[Header("Style")]
		[Range(0f, 1f)]
		public float bulletThicknessScale;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.5f)]
		public float bulletEjectScale;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[Header("Animation")]
		public float bulletDisappearTime;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 6.2831855f)]
		public float bulletEjectAngSpeed;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 6.2831855f)]
		public float ejectRotSpeedVariance;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve bulletEjectX;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve bulletEjectY;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x50")]
		private float[] bulletFireTimes;
	}
}
