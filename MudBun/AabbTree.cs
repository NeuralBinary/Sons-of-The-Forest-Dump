using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class AabbTree<T> where T : class
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public float FatBoundsRadius
		{
			[Token(Token = "0x6000054")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000055")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000013")]
		public NativeArray<AabbTree<T>.NodePod> NodePods
		{
			[Token(Token = "0x6000056")]
			get
			{
				return default(NativeArray<AabbTree<T>.NodePod>);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		public AabbTree(float fatBoundsRadius = 0f, int numInitPods = 0)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		public void Reset()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		public void Dispose()
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x17000014")]
		public int Capacity
		{
			[Token(Token = "0x600005A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x17000015")]
		public int Root
		{
			[Token(Token = "0x600005B")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		public void UpdatePods()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600005D")]
		public int FillComputeBuffer(ComputeBuffer buffer)
		{
			return 0;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600005E")]
		private int AllocateNode()
		{
			return 0;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		private void FreeNode(int node)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000060")]
		public int CreateProxy(Aabb bounds, T userData)
		{
			return 0;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		public void DestroyProxy(int proxy)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		public void UpdateProxy(int proxy, Aabb bounds, int userDataIndex)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x17000016")]
		public Aabb Bounds
		{
			[Token(Token = "0x6000063")]
			get
			{
				return default(Aabb);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000064")]
		public Aabb GetBounds(int proxy)
		{
			return default(Aabb);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000065")]
		public bool Query(Aabb bounds, [Optional] AabbTree<T>.QueryCallbcak callback)
		{
			return default(bool);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6000066")]
		public bool RayCast(Vector3 from, Vector3 to, [Optional] AabbTree<T>.RayCastCallback callback)
		{
			return default(bool);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		private void InsertLeaf(int leaf)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		private void RemoveLeaf(int leaf)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000069")]
		private int Balance(int a)
		{
			return 0;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		public void ForEach(Action<Aabb> f)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600006B")]
		public AabbTree<T> Copy()
		{
			return null;
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Null;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float m_fatBoundsRadius;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AabbTree<T>.Node[] m_nodes;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private NativeArray<AabbTree<T>.NodePod> m_pods;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_podsDirty;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_numNodes;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_freeList;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_root;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Stack<int> m_stack;

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600006E RID: 110
		[Token(Token = "0x2000011")]
		public delegate bool QueryCallbcak(T userData);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000072 RID: 114
		[Token(Token = "0x2000012")]
		public delegate float RayCastCallback(Vector3 from, Vector3 to, T userData);

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public struct Node
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00002490 File Offset: 0x00000690
			[Token(Token = "0x17000017")]
			public bool IsLeaf
			{
				[Token(Token = "0x6000075")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000076 RID: 118 RVA: 0x000024A8 File Offset: 0x000006A8
			[Token(Token = "0x17000018")]
			public bool IsFree
			{
				[Token(Token = "0x6000076")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Aabb Bounds;

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Parent;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int NextFree;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ChildA;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ChildB;

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Height;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T UserData;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int UserDataIndex;
		}

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		[Serializable]
		public struct NodePod
		{
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int Stride;

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Aabb Bounds;

			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Parent;

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ChildA;

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ChildB;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int UserDataIndex;
		}
	}
}
