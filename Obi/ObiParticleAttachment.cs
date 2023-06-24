using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	[AddComponentMenu("Physics/Obi/Obi Particle Attachment", 820)]
	[RequireComponent(typeof(ObiActor))]
	[ExecuteInEditMode]
	public class ObiParticleAttachment : MonoBehaviour
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000150")]
		public ObiActor actor
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000151")]
		public Transform target
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x27F7750", Offset = "0x27F5D50", VA = "0x1827F7750")]
			set
			{
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000152")]
		public ObiParticleGroup particleGroup
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x27F78C0", Offset = "0x27F5EC0", VA = "0x1827F78C0")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x17000153")]
		public bool isBound
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x27F7A30", Offset = "0x27F6030", VA = "0x1827F7A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00004B2C File Offset: 0x00002D2C
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000154")]
		public ObiParticleAttachment.AttachmentType attachmentType
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return ObiParticleAttachment.AttachmentType.Static;
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x27F7B10", Offset = "0x27F6110", VA = "0x1827F7B10")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00004B44 File Offset: 0x00002D44
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000155")]
		public bool constrainOrientation
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x27F7B50", Offset = "0x27F6150", VA = "0x1827F7B50")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00004B5C File Offset: 0x00002D5C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000156")]
		public float compliance
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x27F7B90", Offset = "0x27F6190", VA = "0x1827F7B90")]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00004B74 File Offset: 0x00002D74
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000157")]
		public float breakThreshold
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x27F7E50", Offset = "0x27F6450", VA = "0x1827F7E50")]
			set
			{
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x27F8110", Offset = "0x27F6710", VA = "0x1827F8110")]
		private void Awake()
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x27F8580", Offset = "0x27F6B80", VA = "0x1827F8580")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x27F8830", Offset = "0x27F6E30", VA = "0x1827F8830")]
		private void OnEnable()
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x27F8840", Offset = "0x27F6E40", VA = "0x1827F8840")]
		private void OnDisable()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x27F8850", Offset = "0x27F6E50", VA = "0x1827F8850")]
		private void OnValidate()
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x27F8910", Offset = "0x27F6F10", VA = "0x1827F8910")]
		private void Actor_OnBlueprintLoaded(ObiActor act, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x27F8920", Offset = "0x27F6F20", VA = "0x1827F8920")]
		private void Actor_OnPrepareStep(ObiActor act, float stepTime)
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x27F8930", Offset = "0x27F6F30", VA = "0x1827F8930")]
		private void Actor_OnEndStep(ObiActor act, float stepTime)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x27F8940", Offset = "0x27F6F40", VA = "0x1827F8940")]
		private void Bind()
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x27F94E0", Offset = "0x27F7AE0", VA = "0x1827F94E0")]
		private void EnableAttachment(ObiParticleAttachment.AttachmentType type)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x27F9B80", Offset = "0x27F8180", VA = "0x1827F9B80")]
		private void DisableAttachment(ObiParticleAttachment.AttachmentType type)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x27F9F00", Offset = "0x27F8500", VA = "0x1827F9F00")]
		private void UpdateAttachment()
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x27FA990", Offset = "0x27F8F90", VA = "0x1827FA990")]
		private void BreakDynamicAttachment(float stepTime)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x27FAEA0", Offset = "0x27F94A0", VA = "0x1827FAEA0")]
		public ObiParticleAttachment()
		{
		}

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private ObiActor m_Actor;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private Transform m_Target;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private ObiParticleGroup m_ParticleGroup;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		[SerializeField]
		private ObiParticleAttachment.AttachmentType m_AttachmentType;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		[SerializeField]
		private bool m_ConstrainOrientation;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		private float m_Compliance;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x44")]
		[Delayed]
		[HideInInspector]
		[SerializeField]
		private float m_BreakThreshold;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x48")]
		private ObiPinConstraintsBatch pinBatch;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x50")]
		private ObiColliderBase attachedCollider;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x58")]
		private int attachedColliderHandleIndex;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private int[] m_SolverIndices;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Vector3[] m_PositionOffsets;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Quaternion[] m_OrientationOffsets;

		// Token: 0x020001C5 RID: 453
		[Token(Token = "0x20001C5")]
		public enum AttachmentType
		{
			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			Static,
			// Token: 0x04000762 RID: 1890
			[Token(Token = "0x4000762")]
			Dynamic
		}
	}
}
