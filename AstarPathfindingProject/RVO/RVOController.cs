using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding.RVO
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	[AddComponentMenu("Pathfinding/Local Avoidance/RVO Controller")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_r_v_o_1_1_r_v_o_controller.php")]
	public class RVOController : VersionedMonoBehaviour
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0000686C File Offset: 0x00004A6C
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700016E")]
		public float radius
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x722300", Offset = "0x720900", VA = "0x180722300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x722370", Offset = "0x720970", VA = "0x180722370")]
			set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00006884 File Offset: 0x00004A84
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700016F")]
		public float height
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x7223F0", Offset = "0x7209F0", VA = "0x1807223F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x722460", Offset = "0x720A60", VA = "0x180722460")]
			set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0000689C File Offset: 0x00004A9C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000170")]
		public float center
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x7224E0", Offset = "0x720AE0", VA = "0x1807224E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
			set
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x000068B4 File Offset: 0x00004AB4
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000171")]
		[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
		public LayerMask mask
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x722570", Offset = "0x720B70", VA = "0x180722570")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x000068CC File Offset: 0x00004ACC
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000172")]
		[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
		public bool enableRotation
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000068E4 File Offset: 0x00004AE4
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000173")]
		[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
		public float rotationSpeed
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000068FC File Offset: 0x00004AFC
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000174")]
		[Obsolete("This field is obsolete in version 4.0 and will not affect anything. Use the LegacyRVOController if you need the old behaviour")]
		public float maxSpeed
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00006914 File Offset: 0x00004B14
		[Token(Token = "0x17000175")]
		public MovementPlane movementPlane
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x722580", Offset = "0x720B80", VA = "0x180722580")]
			get
			{
				return MovementPlane.XZ;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000176")]
		public IAgent rvoAgent
		{
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000177")]
		public Simulator simulator
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000178")]
		protected IAstarAI ai
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x7226C0", Offset = "0x720CC0", VA = "0x1807226C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			set
			{
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0000692C File Offset: 0x00004B2C
		[Token(Token = "0x17000179")]
		public Vector3 position
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x722830", Offset = "0x720E30", VA = "0x180722830")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00006944 File Offset: 0x00004B44
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700017A")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x722920", Offset = "0x720F20", VA = "0x180722920")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x722A40", Offset = "0x721040", VA = "0x180722A40")]
			set
			{
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000695C File Offset: 0x00004B5C
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x722AE0", Offset = "0x7210E0", VA = "0x180722AE0")]
		public Vector3 CalculateMovementDelta(float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00006974 File Offset: 0x00004B74
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x722D30", Offset = "0x721330", VA = "0x180722D30")]
		public Vector3 CalculateMovementDelta(Vector3 position, float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x722EA0", Offset = "0x7214A0", VA = "0x180722EA0")]
		public void SetCollisionNormal(Vector3 normal)
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x722A40", Offset = "0x721040", VA = "0x180722A40")]
		[Obsolete("Set the 'velocity' property instead")]
		public void ForceSetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0000698C File Offset: 0x00004B8C
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x722F40", Offset = "0x721540", VA = "0x180722F40")]
		public Vector2 To2D(Vector3 p)
		{
			return default(Vector2);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000069A4 File Offset: 0x00004BA4
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x722F90", Offset = "0x721590", VA = "0x180722F90")]
		public Vector2 To2D(Vector3 p, out float elevation)
		{
			return default(Vector2);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000069BC File Offset: 0x00004BBC
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x723000", Offset = "0x721600", VA = "0x180723000")]
		public Vector3 To3D(Vector2 p, float elevationCoordinate)
		{
			return default(Vector3);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x723070", Offset = "0x721670", VA = "0x180723070")]
		private void OnDisable()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x723090", Offset = "0x721690", VA = "0x180723090")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x7235C0", Offset = "0x721BC0", VA = "0x1807235C0")]
		protected void UpdateAgentProperties()
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x7239D0", Offset = "0x721FD0", VA = "0x1807239D0")]
		public void SetTarget(Vector3 pos, float speed, float maxSpeed)
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x723AC0", Offset = "0x7220C0", VA = "0x180723AC0")]
		public void Move(Vector3 vel)
		{
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x723D30", Offset = "0x722330", VA = "0x180723D30")]
		[Obsolete("Use transform.position instead, the RVOController can now handle that without any issues.")]
		public void Teleport(Vector3 pos)
		{
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x723DB0", Offset = "0x7223B0", VA = "0x180723DB0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000069D4 File Offset: 0x00004BD4
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x7242C0", Offset = "0x7228C0", VA = "0x1807242C0", Slot = "9")]
		protected override int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x7246B0", Offset = "0x722CB0", VA = "0x1807246B0")]
		public RVOController()
		{
		}

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("radius")]
		internal float radiusBackingField;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[FormerlySerializedAs("height")]
		private float heightBackingField;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("center")]
		[SerializeField]
		private float centerBackingField;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("A locked unit cannot move. Other units will still avoid it. But avoidance quality is not the best")]
		public bool locked;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x35")]
		[Tooltip("Automatically set #locked to true when desired velocity is approximately zero")]
		public bool lockWhenNotMoving;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("How far into the future to look for collisions with other agents (in seconds)")]
		public float agentTimeHorizon;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("How far into the future to look for collisions with obstacles (in seconds)")]
		public float obstacleTimeHorizon;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Max number of other agents to take into account.\nA smaller value can reduce CPU load, a higher value can lead to better local avoidance quality.")]
		public int maxNeighbours;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x44")]
		public RVOLayer layer;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x48")]
		[EnumFlag]
		public RVOLayer collidesWith;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		[Obsolete]
		public float wallAvoidForce;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[Obsolete]
		public float wallAvoidFalloff;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("How strongly other agents will avoid this agent")]
		[Range(0f, 1f)]
		public float priority;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x68")]
		protected Transform tr;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("ai")]
		private IAstarAI aiBackingField;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x78")]
		public bool debug;
	}
}
