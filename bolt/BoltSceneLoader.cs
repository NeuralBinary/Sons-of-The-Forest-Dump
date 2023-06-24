using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
internal class BoltSceneLoader : MonoBehaviour
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x1700001E")]
	internal static bool IsLoading
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x7807D0", Offset = "0x77EDD0", VA = "0x1807807D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x780840", Offset = "0x77EE40", VA = "0x180780840")]
	private void Update()
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x780C90", Offset = "0x77F290", VA = "0x180780C90")]
	private void Load()
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x780E00", Offset = "0x77F400", VA = "0x180780E00")]
	private void LoadAsync()
	{
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x781150", Offset = "0x77F750", VA = "0x180781150")]
	private void Done()
	{
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x781310", Offset = "0x77F910", VA = "0x180781310")]
	internal static void Enqueue(SceneLoadState scene)
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public BoltSceneLoader()
	{
	}

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x0")]
	private static int _delay;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x8")]
	private static SceneLoadState _loaded;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x20")]
	private static readonly BoltSingleList<BoltSceneLoader.LoadOp> _loadOps;

	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	private class LoadOp : BoltObject
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public LoadOp()
		{
		}

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		public SceneLoadState scene;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x40")]
		public AsyncOperation async;
	}
}
