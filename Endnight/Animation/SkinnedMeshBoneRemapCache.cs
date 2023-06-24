using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[AddComponentMenu("Endnight/Animation/Skinned Mesh Bone Remap Cache")]
	public class SkinnedMeshBoneRemapCache : MonoBehaviour
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004E")]
		public List<string> CachedBonePaths
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700004F")]
		public string CachedRootBonePath
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xAB1B00", Offset = "0xAB0100", VA = "0x180AB1B00")]
		public static void RetargetBonesToTransform(Transform model, Transform animationRoot, bool playerRobbyFixHack = false)
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xAB1C30", Offset = "0xAB0230", VA = "0x180AB1C30")]
		public static string ConvertToRobbyPlayer(string bonePath)
		{
			return null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xAB1C90", Offset = "0xAB0290", VA = "0x180AB1C90")]
		public static void RetargetBones(SkinnedMeshBoneRemapCache skinnedMeshBoneRemapCache, Transform animationRoot, bool playerRobbyFixHack = false)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SkinnedMeshBoneRemapCache()
		{
		}

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _autoCacheOnValidate;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _cachedRootBonePath;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _cachedBonePaths;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Bounds _rendererBounds;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _skipTransformMatching;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		private Transform _targetRigAnimationRoot;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private string _transformBasePath;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _sourceTransformBasePath;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _applyRigAnimationRoot;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private bool _isCompatible;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x80")]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x88")]
		private List<Transform> _bones;

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x90")]
		private List<string> _bonePaths;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, Transform> _targetRigBonePaths;

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0xA0")]
		private Transform _rootBone;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0xA8")]
		private string _rootBonePath;
	}
}
