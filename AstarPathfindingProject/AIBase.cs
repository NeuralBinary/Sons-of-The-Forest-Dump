using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.RVO;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[RequireComponent(typeof(Seeker))]
	public abstract class AIBase : VersionedMonoBehaviour
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000022DC File Offset: 0x000004DC
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000018")]
		public float repathRate
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x61BC20", Offset = "0x61A220", VA = "0x18061BC20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x61BC40", Offset = "0x61A240", VA = "0x18061BC40")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000019")]
		public bool canSearch
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x61BC60", Offset = "0x61A260", VA = "0x18061BC60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x61BC90", Offset = "0x61A290", VA = "0x18061BC90")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001A")]
		[Obsolete("Use the height property instead (2x this value)")]
		public float centerOffset
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x61BCE0", Offset = "0x61A2E0", VA = "0x18061BCE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x61BCF0", Offset = "0x61A2F0", VA = "0x18061BCF0")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001B")]
		[Obsolete("Use orientation instead")]
		public bool rotationIn2D
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x61BD00", Offset = "0x61A300", VA = "0x18061BD00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x61BD10", Offset = "0x61A310", VA = "0x18061BD10")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x1700001C")]
		public Vector3 position
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x61BD30", Offset = "0x61A330", VA = "0x18061BD30", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001D")]
		public Quaternion rotation
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x61BDF0", Offset = "0x61A3F0", VA = "0x18061BDF0", Slot = "11")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x61BE90", Offset = "0x61A490", VA = "0x18061BE90", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000236C File Offset: 0x0000056C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001E")]
		protected bool usingGravity
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x61BF20", Offset = "0x61A520", VA = "0x18061BF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x61BF30", Offset = "0x61A530", VA = "0x18061BF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001F")]
		[Obsolete("Use the destination property or the AIDestinationSetter component instead")]
		public Transform target
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x61BF40", Offset = "0x61A540", VA = "0x18061BF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x61C020", Offset = "0x61A620", VA = "0x18061C020")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000020")]
		public Vector3 destination
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x61C330", Offset = "0x61A930", VA = "0x18061C330", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x61C350", Offset = "0x61A950", VA = "0x18061C350", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000021")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x61C370", Offset = "0x61A970", VA = "0x18061C370", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x17000022")]
		public Vector3 desiredVelocity
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x61C440", Offset = "0x61AA40", VA = "0x18061C440", Slot = "16")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000023")]
		public bool isStopped
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x61C530", Offset = "0x61AB30", VA = "0x18061C530", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x61C540", Offset = "0x61AB40", VA = "0x18061C540", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000024")]
		public Action onSearchPath
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x61C560", Offset = "0x61AB60", VA = "0x18061C560", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x17000025")]
		protected virtual bool shouldRecalculatePath
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x61C5C0", Offset = "0x61ABC0", VA = "0x18061C5C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x61C660", Offset = "0x61AC60", VA = "0x18061C660")]
		protected AIBase()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x61C8C0", Offset = "0x61AEC0", VA = "0x18061C8C0", Slot = "22")]
		public virtual void FindComponents()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x61CBB0", Offset = "0x61B1B0", VA = "0x18061CBB0", Slot = "23")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x61CCF0", Offset = "0x61B2F0", VA = "0x18061CCF0", Slot = "24")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x61CD00", Offset = "0x61B300", VA = "0x18061CD00")]
		private void Init()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x61CDC0", Offset = "0x61B3C0", VA = "0x18061CDC0", Slot = "25")]
		public virtual void Teleport(Vector3 newPosition, bool clearPath = true)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x61CFC0", Offset = "0x61B5C0", VA = "0x18061CFC0")]
		protected void CancelCurrentPathRequest()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x61D100", Offset = "0x61B700", VA = "0x18061D100", Slot = "26")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x61D2E0", Offset = "0x61B8E0", VA = "0x18061D2E0", Slot = "27")]
		protected virtual void Update()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x61D6F0", Offset = "0x61BCF0", VA = "0x18061D6F0", Slot = "28")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x61D910", Offset = "0x61BF10", VA = "0x18061D910", Slot = "29")]
		public void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
		}

		// Token: 0x060000A6 RID: 166
		[Token(Token = "0x60000A6")]
		protected abstract void MovementUpdateInternal(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation);

		// Token: 0x060000A7 RID: 167 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x61D930", Offset = "0x61BF30", VA = "0x18061D930", Slot = "31")]
		protected virtual void CalculatePathRequestEndpoints(out Vector3 start, out Vector3 end)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x61D9A0", Offset = "0x61BFA0", VA = "0x18061D9A0", Slot = "32")]
		public virtual void SearchPath()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x61DAE0", Offset = "0x61C0E0", VA = "0x18061DAE0", Slot = "33")]
		public virtual Vector3 GetFeetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060000AA RID: 170
		[Token(Token = "0x60000AA")]
		protected abstract void OnPathComplete(Path newPath);

		// Token: 0x060000AB RID: 171
		[Token(Token = "0x60000AB")]
		protected abstract void ClearPath();

		// Token: 0x060000AC RID: 172 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x61DB10", Offset = "0x61C110", VA = "0x18061DB10", Slot = "36")]
		public void SetPath(Path path, bool updateDestinationFromPath = true)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x61DDA0", Offset = "0x61C3A0", VA = "0x18061DDA0")]
		protected void ApplyGravity(float deltaTime)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x61E030", Offset = "0x61C630", VA = "0x18061E030")]
		protected Vector2 CalculateDeltaToMoveThisFrame(Vector2 position, float distanceToEndOfPath, float deltaTime)
		{
			return default(Vector2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x61E360", Offset = "0x61C960", VA = "0x18061E360")]
		public Quaternion SimulateRotationTowards(Vector3 direction, float maxDegrees)
		{
			return default(Quaternion);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x61E410", Offset = "0x61CA10", VA = "0x18061E410")]
		protected Quaternion SimulateRotationTowards(Vector2 direction, float maxDegrees)
		{
			return default(Quaternion);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x61E700", Offset = "0x61CD00", VA = "0x18061E700", Slot = "37")]
		public virtual void Move(Vector3 deltaPosition)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x61E760", Offset = "0x61CD60", VA = "0x18061E760", Slot = "38")]
		public virtual void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x61E7C0", Offset = "0x61CDC0", VA = "0x18061E7C0")]
		private void FinalizeRotation(Quaternion nextRotation)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x61EA60", Offset = "0x61D060", VA = "0x18061EA60")]
		private void FinalizePosition(Vector3 nextPosition)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x61F1A0", Offset = "0x61D7A0", VA = "0x18061F1A0")]
		protected void UpdateVelocity()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x61F250", Offset = "0x61D850", VA = "0x18061F250", Slot = "39")]
		protected virtual Vector3 ClampToNavmesh(Vector3 position, out bool positionChanged)
		{
			return default(Vector3);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x61F270", Offset = "0x61D870", VA = "0x18061F270")]
		protected Vector3 RaycastPosition(Vector3 position, float lastElevation)
		{
			return default(Vector3);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x61F680", Offset = "0x61DC80", VA = "0x18061F680", Slot = "40")]
		protected virtual void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x61F720", Offset = "0x61DD20", VA = "0x18061F720", Slot = "41")]
		protected virtual void OnDrawGizmos()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x61FE90", Offset = "0x61E490", VA = "0x18061FE90", Slot = "8")]
		protected override void Reset()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x61FED0", Offset = "0x61E4D0", VA = "0x18061FED0")]
		private void ResetShape()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x620050", Offset = "0x61E650", VA = "0x180620050", Slot = "9")]
		protected override int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		public float radius;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x2C")]
		public float height;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x30")]
		public bool canMove;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x34")]
		[FormerlySerializedAs("speed")]
		public float maxSpeed;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 gravity;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x44")]
		public LayerMask groundMask;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("centerOffset")]
		private float centerOffsetCompatibility;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		[FormerlySerializedAs("repathRate")]
		[SerializeField]
		private float repathRateCompatibility;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("canSearch")]
		[FormerlySerializedAs("repeatedlySearchPaths")]
		private bool canSearchCompability;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x54")]
		[FormerlySerializedAs("rotationIn2D")]
		public OrientationMode orientation;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x58")]
		public bool enableRotation;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x5C")]
		protected Vector3 simulatedPosition;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x68")]
		protected Quaternion simulatedRotation;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 accumulatedMovementDelta;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x84")]
		protected Vector2 velocity2D;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x8C")]
		protected float verticalVelocity;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x90")]
		protected Seeker seeker;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x98")]
		protected Transform tr;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xA0")]
		protected Rigidbody rigid;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xA8")]
		protected Rigidbody2D rigid2D;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0xB0")]
		protected CharacterController controller;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0xB8")]
		protected RVOController rvoController;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xC0")]
		public IMovementPlane movementPlane;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		public bool updatePosition;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0xC9")]
		[NonSerialized]
		public bool updateRotation;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xD0")]
		public AutoRepathPolicy autoRepath;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xDC")]
		protected float lastDeltaTime;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xE0")]
		protected int prevFrame;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xE4")]
		protected Vector3 prevPosition1;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xF0")]
		protected Vector3 prevPosition2;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xFC")]
		protected Vector2 lastDeltaPosition;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x104")]
		protected bool waitingForPathCalculation;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("target")]
		private Transform targetCompatibility;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x110")]
		private bool startHasRun;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color ShapeGizmoColor;
	}
}
