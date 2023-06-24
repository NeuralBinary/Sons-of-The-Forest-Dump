using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	[AddComponentMenu("Sons/Physics/Trigger Toggle Game Object")]
	public class TriggerToggleGameObject : MonoBehaviour
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xA9E100", Offset = "0xA9C700", VA = "0x180A9E100")]
		private void OnValidate()
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0xA9E270", Offset = "0xA9C870", VA = "0x180A9E270")]
		private void AddOrFixTag(string tagName)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xA9E470", Offset = "0xA9CA70", VA = "0x180A9E470")]
		private void Awake()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xA9E4E0", Offset = "0xA9CAE0", VA = "0x180A9E4E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xA9E560", Offset = "0xA9CB60", VA = "0x180A9E560")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xA9E9A0", Offset = "0xA9CFA0", VA = "0x180A9E9A0")]
		private void SetSkinnedMotionVectors(List<SkinnedMeshRenderer> targets, bool value)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xA9EB20", Offset = "0xA9D120", VA = "0x180A9EB20")]
		private bool CheckFrame(int frameMarker)
		{
			return default(bool);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xA9EB80", Offset = "0xA9D180", VA = "0x180A9EB80")]
		private void CheckDisableTimer()
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xA9EC00", Offset = "0xA9D200", VA = "0x180A9EC00")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0xA9ECB0", Offset = "0xA9D2B0", VA = "0x180A9ECB0")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA9ED40", Offset = "0xA9D340", VA = "0x180A9ED40")]
		private bool MatchesTag(Collider other)
		{
			return default(bool);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA9EEB0", Offset = "0xA9D4B0", VA = "0x180A9EEB0")]
		private void ToggleDisabled()
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xA9EF20", Offset = "0xA9D520", VA = "0x180A9EF20")]
		private void Apply(bool value)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA9F350", Offset = "0xA9D950", VA = "0x180A9F350")]
		private bool HasApplied(bool value)
		{
			return default(bool);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA9F380", Offset = "0xA9D980", VA = "0x180A9F380")]
		public TriggerToggleGameObject()
		{
		}

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private string _tagMatch;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _tagMatches;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool _tagMatchIgnoreCase;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _delayBeforeDisable;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _targetEnterOn;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<SkinnedMeshRenderer> _targetSkinnedMeshesOn;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<GameObject> _targetEnterOff;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<SkinnedMeshRenderer> _targetSkinnedMeshesOff;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _disableTimerStart;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x5C")]
		private int _onFrame;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x60")]
		private int _offFrame;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x64")]
		private bool _appliedOff;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x65")]
		private bool _appliedOn;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x68")]
		private int _frameUpdate;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		private const int MaxFrameDistribution = 5;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<Collider> _activeColliders;
	}
}
