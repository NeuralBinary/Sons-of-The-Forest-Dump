using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[RequireComponent(typeof(Seeker))]
	[AddComponentMenu("Pathfinding/AI/AILerp (2D,3D)")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_a_i_lerp.php")]
	public class AILerp : VersionedMonoBehaviour, IAstarAI
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000024A4 File Offset: 0x000006A4
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000026")]
		public float repathRate
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x6202B0", Offset = "0x61E8B0", VA = "0x1806202B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x6202D0", Offset = "0x61E8D0", VA = "0x1806202D0")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000024BC File Offset: 0x000006BC
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000027")]
		public bool canSearch
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x6202F0", Offset = "0x61E8F0", VA = "0x1806202F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x620310", Offset = "0x61E910", VA = "0x180620310")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000028")]
		[Obsolete("Use orientation instead")]
		public bool rotationIn2D
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x620330", Offset = "0x61E930", VA = "0x180620330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x620340", Offset = "0x61E940", VA = "0x180620340")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000029")]
		public bool reachedEndOfPath
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x620360", Offset = "0x61E960", VA = "0x180620360", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x620370", Offset = "0x61E970", VA = "0x180620370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x1700002A")]
		public bool reachedDestination
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x620380", Offset = "0x61E980", VA = "0x180620380", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700002B")]
		public Vector3 destination
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x620480", Offset = "0x61EA80", VA = "0x180620480", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x6204A0", Offset = "0x61EAA0", VA = "0x1806204A0", Slot = "25")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700002C")]
		[Obsolete("Use the destination property or the AIDestinationSetter component instead")]
		public Transform target
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x6204B0", Offset = "0x61EAB0", VA = "0x1806204B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x620590", Offset = "0x61EB90", VA = "0x180620590")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x1700002D")]
		public Vector3 position
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x6208A0", Offset = "0x61EEA0", VA = "0x1806208A0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700002E")]
		public Quaternion rotation
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x620960", Offset = "0x61EF60", VA = "0x180620960", Slot = "15")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x620A00", Offset = "0x61F000", VA = "0x180620A00", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "41")]
		private void Move(Vector3 deltaPosition)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700002F")]
		private float radius
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000030")]
		private float height
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "12")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000031")]
		private float maxSpeed
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0", Slot = "17")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000025AC File Offset: 0x000007AC
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000032")]
		private bool canSearch
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x6202F0", Offset = "0x61E8F0", VA = "0x1806202F0", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x620310", Offset = "0x61E910", VA = "0x180620310", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000033")]
		private bool canMove
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000025DC File Offset: 0x000007DC
		[Token(Token = "0x17000034")]
		public Vector3 velocity
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x620AE0", Offset = "0x61F0E0", VA = "0x180620AE0", Slot = "19")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x17000035")]
		private Vector3 desiredVelocity
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x620C70", Offset = "0x61F270", VA = "0x180620C70", Slot = "20")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000260C File Offset: 0x0000080C
		[Token(Token = "0x17000036")]
		private Vector3 steeringTarget
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x620D40", Offset = "0x61F340", VA = "0x180620D40", Slot = "34")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000037")]
		public float remainingDistance
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x620E40", Offset = "0x61F440", VA = "0x180620E40", Slot = "21")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x620E70", Offset = "0x61F470", VA = "0x180620E70")]
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000263C File Offset: 0x0000083C
		[Token(Token = "0x17000038")]
		public bool hasPath
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x620EB0", Offset = "0x61F4B0", VA = "0x180620EB0", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002654 File Offset: 0x00000854
		[Token(Token = "0x17000039")]
		public bool pathPending
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x620EE0", Offset = "0x61F4E0", VA = "0x180620EE0", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700003A")]
		public bool isStopped
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x620EF0", Offset = "0x61F4F0", VA = "0x180620EF0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x620F00", Offset = "0x61F500", VA = "0x180620F00", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700003B")]
		public Action onSearchPath
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20", Slot = "36")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x620F80", Offset = "0x61F580", VA = "0x180620F80")]
		protected AILerp()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x621170", Offset = "0x61F770", VA = "0x180621170", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x621370", Offset = "0x61F970", VA = "0x180621370", Slot = "44")]
		protected virtual void Start()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x621380", Offset = "0x61F980", VA = "0x180621380", Slot = "45")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x6214B0", Offset = "0x61FAB0", VA = "0x1806214B0")]
		private void Init()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x6215D0", Offset = "0x61FBD0", VA = "0x1806215D0")]
		public void OnDisable()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x621710", Offset = "0x61FD10", VA = "0x180621710", Slot = "37")]
		public void GetRemainingPath(List<Vector3> buffer, out bool stale)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x6218B0", Offset = "0x61FEB0", VA = "0x1806218B0", Slot = "40")]
		public void Teleport(Vector3 position, bool clearPath = true)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002684 File Offset: 0x00000884
		[Token(Token = "0x1700003C")]
		protected virtual bool shouldRecalculatePath
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x6219B0", Offset = "0x61FFB0", VA = "0x1806219B0", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x621A50", Offset = "0x620050", VA = "0x180621A50", Slot = "47")]
		[Obsolete("Use SearchPath instead")]
		public virtual void ForceSearchPath()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x621A70", Offset = "0x620070", VA = "0x180621A70", Slot = "48")]
		public virtual void SearchPath()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "49")]
		public virtual void OnTargetReached()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x621B80", Offset = "0x620180", VA = "0x180621B80", Slot = "50")]
		protected virtual void OnPathComplete(Path _p)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x621E60", Offset = "0x620460", VA = "0x180621E60", Slot = "51")]
		protected virtual void ClearPath()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x622030", Offset = "0x620630", VA = "0x180622030", Slot = "39")]
		public void SetPath(Path path, bool updateDestinationFromPath = true)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x622290", Offset = "0x620890", VA = "0x180622290", Slot = "52")]
		protected virtual void ConfigurePathSwitchInterpolation()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x6224C0", Offset = "0x620AC0", VA = "0x1806224C0", Slot = "53")]
		public virtual Vector3 GetFeetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x6224F0", Offset = "0x620AF0", VA = "0x1806224F0", Slot = "54")]
		protected virtual void ConfigureNewPath()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x6227E0", Offset = "0x620DE0", VA = "0x1806227E0", Slot = "55")]
		protected virtual void Update()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x622B30", Offset = "0x621130", VA = "0x180622B30", Slot = "42")]
		public void MovementUpdate(float deltaTime, out Vector3 nextPosition, out Quaternion nextRotation)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x622D00", Offset = "0x621300", VA = "0x180622D00", Slot = "43")]
		public void FinalizeMovement(Vector3 nextPosition, Quaternion nextRotation)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x622E40", Offset = "0x621440", VA = "0x180622E40")]
		private Quaternion SimulateRotationTowards(Vector3 direction, float deltaTime)
		{
			return default(Quaternion);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000026CC File Offset: 0x000008CC
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x623120", Offset = "0x621720", VA = "0x180623120", Slot = "56")]
		protected virtual Vector3 CalculateNextPosition(out Vector3 direction, float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x6233F0", Offset = "0x6219F0", VA = "0x1806233F0", Slot = "9")]
		protected override int OnUpgradeSerializedData(int version, bool unityThread)
		{
			return 0;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x623520", Offset = "0x621B20", VA = "0x180623520", Slot = "57")]
		public virtual void OnDrawGizmos()
		{
		}

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x28")]
		public AutoRepathPolicy autoRepath;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x30")]
		public bool canMove;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x34")]
		public float speed;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("rotationIn2D")]
		public OrientationMode orientation;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x3C")]
		public bool enableRotation;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x40")]
		public float rotationSpeed;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x44")]
		public bool interpolatePathSwitches;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x48")]
		public float switchPathInterpolationSpeed;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x5C")]
		[NonSerialized]
		public bool updatePosition;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x5D")]
		[NonSerialized]
		public bool updateRotation;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x68")]
		protected Seeker seeker;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x70")]
		protected Transform tr;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x78")]
		protected ABPath path;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x80")]
		protected bool canSearchAgain;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x84")]
		protected Vector3 previousMovementOrigin;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x90")]
		protected Vector3 previousMovementDirection;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x9C")]
		protected float pathSwitchInterpolationTime;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0xA0")]
		protected PathInterpolator interpolator;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0xA8")]
		private bool startHasRun;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 previousPosition1;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 previousPosition2;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 simulatedPosition;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion simulatedRotation;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xE0")]
		[FormerlySerializedAs("target")]
		[SerializeField]
		[HideInInspector]
		private Transform targetCompatibility;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xE8")]
		[FormerlySerializedAs("repathRate")]
		[HideInInspector]
		[SerializeField]
		private float repathRateCompatibility;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("canSearch")]
		private bool canSearchCompability;
	}
}
