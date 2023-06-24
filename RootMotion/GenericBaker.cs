using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class GenericBaker : Baker
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x28D8E10", Offset = "0x28D7410", VA = "0x1828D8E10")]
		private void Awake()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x28D9300", Offset = "0x28D7900", VA = "0x1828D9300", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x28D94B0", Offset = "0x28D7AB0", VA = "0x1828D94B0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x28D9A60", Offset = "0x28D8060", VA = "0x1828D9A60", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x28D9AF0", Offset = "0x28D80F0", VA = "0x1828D9AF0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x28DA1C0", Offset = "0x28D87C0", VA = "0x1828DA1C0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x28DA340", Offset = "0x28D8940", VA = "0x1828DA340")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x28DA4C0", Offset = "0x28D8AC0", VA = "0x1828DA4C0")]
		public GenericBaker()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xA8")]
		private BakerTransform[] children;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xB0")]
		private BakerTransform rootChild;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0xB8")]
		private int rootChildIndex;
	}
}
