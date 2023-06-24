using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class ScopeZeroingGenerator : MonoBehaviour
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x90AC00", Offset = "0x909200", VA = "0x18090AC00")]
		private void Awake()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x90ACB0", Offset = "0x9092B0", VA = "0x18090ACB0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x90B450", Offset = "0x909A50", VA = "0x18090B450")]
		public void AddEntry(float distance)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x90B4F0", Offset = "0x909AF0", VA = "0x18090B4F0")]
		public int GetZeroEntryCount()
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x90B530", Offset = "0x909B30", VA = "0x18090B530")]
		public ScopeZeroingGenerator.ZeroEntry GetZeroEntry(int index)
		{
			return default(ScopeZeroingGenerator.ZeroEntry);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x90B5B0", Offset = "0x909BB0", VA = "0x18090B5B0")]
		public ScopeZeroingGenerator.ZeroEntry[] GetZeroEntries()
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x90B6D0", Offset = "0x909CD0", VA = "0x18090B6D0")]
		public void UpdateZeroEntry(int index, float distance)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x90AC00", Offset = "0x909200", VA = "0x18090AC00")]
		public void UpdateAllZeroEntries()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x90BE00", Offset = "0x90A400", VA = "0x18090BE00")]
		public void RemoveZeroEntry(int index)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x90BEA0", Offset = "0x90A4A0", VA = "0x18090BEA0")]
		public void UpdateIndicators()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x90C990", Offset = "0x90AF90", VA = "0x18090C990")]
		public void DeleteIndicators()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x90CB90", Offset = "0x90B190", VA = "0x18090CB90")]
		private void orderZeroEntries()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x90CD80", Offset = "0x90B380", VA = "0x18090CD80")]
		private Vector3 calculateIndicatorPosition(ScopeZeroingGenerator.ZeroEntry entry)
		{
			return default(Vector3);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x90CFC0", Offset = "0x90B5C0", VA = "0x18090CFC0")]
		public ScopeZeroingGenerator()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x20")]
		public Weapon weapon;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		public bool correctScopeOffset;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		public Transform indicatorPrefab;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x38")]
		public float indicatorOffset;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x3C")]
		public float indicatorSize;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x40")]
		public bool drawGizmos;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x44")]
		public float gizmoWidth;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x48")]
		public Color gizmoColor;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<ScopeZeroingGenerator.ZeroEntry> zeroEntries;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<Transform> indicators;

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		[Serializable]
		public struct ZeroEntry
		{
			// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x5B25C0", Offset = "0x5B0BC0", VA = "0x1805B25C0")]
			public ZeroEntry(float distance, float angle)
			{
			}

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x0")]
			public float distance;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x4")]
			public float angle;
		}
	}
}
