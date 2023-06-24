using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class TreeWindSfxManager : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x315AFA0", Offset = "0x31595A0", VA = "0x18315AFA0")]
	private static TreeWindSfxManager.TreeInfo GetTreeInfo(TreeWindSfx tree)
	{
		return null;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x315B090", Offset = "0x3159690", VA = "0x18315B090")]
	public static void Add(TreeWindSfx tree)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x315B2E0", Offset = "0x31598E0", VA = "0x18315B2E0")]
	public static void Remove(TreeWindSfx tree)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x315B4E0", Offset = "0x3159AE0", VA = "0x18315B4E0")]
	private static void Swap(List<TreeWindSfxManager.TreeInfo> trees, int a, int b)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x315B5B0", Offset = "0x3159BB0", VA = "0x18315B5B0")]
	private void Start()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0xB0DD00", Offset = "0xB0C300", VA = "0x180B0DD00")]
	private static void Fill(Texture2D texture, Color color)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x315B6C0", Offset = "0x3159CC0", VA = "0x18315B6C0")]
	private static void DrawDiamond(Texture2D texture, Color color)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x315B840", Offset = "0x3159E40", VA = "0x18315B840")]
	private static void CreateDebugTextures()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x315BE00", Offset = "0x315A400", VA = "0x18315BE00")]
	private static void DrawDebug()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x315C860", Offset = "0x315AE60", VA = "0x18315C860")]
	private static void OccludeTrees(TreeWindSfxManager.TreeInfo occluder, float occlusionWidth, List<TreeWindSfxManager.TreeInfo> trees, int startIndex)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x315CAC0", Offset = "0x315B0C0", VA = "0x18315CAC0")]
	private void DoWork()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x315D100", Offset = "0x315B700", VA = "0x18315D100")]
	public static float ConvertWindIntensity(float windIntensity)
	{
		return 0f;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x315D1E0", Offset = "0x315B7E0", VA = "0x18315D1E0")]
	public TreeWindSfxManager()
	{
	}

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("TargetActiveCount")]
	[Tooltip("The target number of active trees")]
	public int _targetActiveCount;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("The width used when occluding distant trees with close trees")]
	[FormerlySerializedAs("TreeOcclusionWidth")]
	public float _treeOcclusionWidth;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("The time in seconds that trees persist after going inactive before stopping their SFX")]
	[FormerlySerializedAs("TreePersistTime")]
	public float _treePersistTime;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x2C")]
	[Tooltip("The time in seconds between updates")]
	[FormerlySerializedAs("UpdatePeriod")]
	public float _updatePeriod;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<TreeWindSfx> TreesHashSet;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 _windRange;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x8")]
	private static Vector2 _globalWindRange;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x10")]
	private static List<TreeWindSfxManager.TreeInfo> _treeInfoList;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x18")]
	private static Queue<TreeWindSfxManager.TreeInfo> _treeInfoListPool;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x20")]
	private static Texture2D _activeTexture;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x28")]
	private static Texture2D _inactiveTexture;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	private static Texture2D _playerTexture;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	private const float TwoPI = 6.2831855f;

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private class TreeInfo
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x315D5E0", Offset = "0x315BBE0", VA = "0x18315D5E0")]
		public TreeInfo(TreeWindSfx tree)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x315D5F0", Offset = "0x315BBF0", VA = "0x18315D5F0")]
		public void Init(TreeWindSfx tree)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x315D720", Offset = "0x315BD20", VA = "0x18315D720")]
		public void Clear()
		{
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		public TreeWindSfx Tree;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x18")]
		public int TreeWindSfxInstanceId;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Position;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x28")]
		public float SqrDistance;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x2C")]
		public float Direction;
	}
}
