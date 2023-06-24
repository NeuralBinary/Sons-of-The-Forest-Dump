using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Ai;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	public abstract class Structure : MonoBehaviour, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001063 RID: 4195
		[Token(Token = "0x170003CE")]
		public abstract ushort TypeID { [Token(Token = "0x6001063")] get; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00009F5C File Offset: 0x0000815C
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003CF")]
		public uint InstanceID
		{
			[Token(Token = "0x6001064")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001065")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00009F74 File Offset: 0x00008174
		[Token(Token = "0x170003D0")]
		public virtual bool StackedElements
		{
			[Token(Token = "0x6001066")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D1")]
		public SuperStructure SuperStructure
		{
			[Token(Token = "0x6001067")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "45")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001068")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003D2")]
		public virtual Transform ElementRoot
		{
			[Token(Token = "0x6001069")]
			[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00009F8C File Offset: 0x0000818C
		[Token(Token = "0x170003D3")]
		public virtual int LinkedStructureCount
		{
			[Token(Token = "0x600106A")]
			[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00009FA4 File Offset: 0x000081A4
		[Token(Token = "0x170003D4")]
		public virtual int LinkedStructureCountForSuperStructure
		{
			[Token(Token = "0x600106B")]
			[Address(RVA = "0x2F118B0", Offset = "0x2F0FEB0", VA = "0x182F118B0", Slot = "51")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003D5")]
		public virtual Directions[] Supporting
		{
			[Token(Token = "0x600106C")]
			[Address(RVA = "0x2F118D0", Offset = "0x2F0FED0", VA = "0x182F118D0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003D6")]
		public virtual Directions[] SupportedBy
		{
			[Token(Token = "0x600106D")]
			[Address(RVA = "0x2F11920", Offset = "0x2F0FF20", VA = "0x182F11920", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003D7")]
		public virtual Directions[] SupportedByWithRepairPriority
		{
			[Token(Token = "0x600106E")]
			[Address(RVA = "0x2F11970", Offset = "0x2F0FF70", VA = "0x182F11970", Slot = "54")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00009FBC File Offset: 0x000081BC
		[Token(Token = "0x170003D8")]
		public virtual bool AllowSuperStructureMerge
		{
			[Token(Token = "0x600106F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "55")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x2F119C0", Offset = "0x2F0FFC0", VA = "0x182F119C0", Slot = "56")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30", Slot = "57")]
		public virtual void SetInstanceID(uint instanceID)
		{
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "58")]
		public virtual void SetSuperStructure(SuperStructure ss)
		{
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "59")]
		public virtual void OnPostLoad()
		{
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "60")]
		protected virtual void OnDisassemblingStructure()
		{
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x2F11C20", Offset = "0x2F10220", VA = "0x182F11C20", Slot = "61")]
		public virtual void OnDestroyingStructure()
		{
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "62")]
		public virtual void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "63")]
		public virtual void OnElementsChanged()
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "64")]
		public virtual void OnElementsChangedClient()
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "65")]
		public virtual void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "66")]
		public virtual void OnLinkedStructuresChangedClient()
		{
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00009FD4 File Offset: 0x000081D4
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "67")]
		public virtual RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00009FEC File Offset: 0x000081EC
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x2F11D80", Offset = "0x2F10380", VA = "0x182F11D80", Slot = "68")]
		public virtual int CountElements()
		{
			return 0;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0000A004 File Offset: 0x00008204
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x2F11E40", Offset = "0x2F10440", VA = "0x182F11E40", Slot = "69")]
		public virtual bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0000A01C File Offset: 0x0000821C
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x2F11EA0", Offset = "0x2F104A0", VA = "0x182F11EA0", Slot = "70")]
		public virtual int CalcMaxElements()
		{
			return 0;
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0000A034 File Offset: 0x00008234
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "71")]
		public virtual int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x2F11ED0", Offset = "0x2F104D0", VA = "0x182F11ED0", Slot = "33")]
		public StructureElement GetFirstElement()
		{
			return null;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x2F11F80", Offset = "0x2F10580", VA = "0x182F11F80")]
		protected StructureElement GetFirstRealElement()
		{
			return null;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x2F120A0", Offset = "0x2F106A0", VA = "0x182F120A0", Slot = "34")]
		public StructureElement GetLastElement()
		{
			return null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x2F121C0", Offset = "0x2F107C0", VA = "0x182F121C0", Slot = "40")]
		public StructureElement GetNthElement(int elementNum)
		{
			return null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0000A04C File Offset: 0x0000824C
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x2F12270", Offset = "0x2F10870", VA = "0x182F12270", Slot = "72")]
		public virtual int CalcNextElementNumber()
		{
			return 0;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0000A064 File Offset: 0x00008264
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x2E87DF0", Offset = "0x2E863F0", VA = "0x182E87DF0", Slot = "73")]
		public virtual Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0000A07C File Offset: 0x0000827C
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x2F12290", Offset = "0x2F10890", VA = "0x182F12290", Slot = "74")]
		public virtual Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0000A094 File Offset: 0x00008294
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x8F5680", Offset = "0x8F3C80", VA = "0x1808F5680", Slot = "75")]
		public virtual Vector3 CalcElementPosition(StructureElement elementPrefab, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0000A0AC File Offset: 0x000082AC
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x2F12390", Offset = "0x2F10990", VA = "0x182F12390", Slot = "76")]
		public virtual Quaternion CalcNextElementRotation(StructureElement elementPrefab)
		{
			return default(Quaternion);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x2F12400", Offset = "0x2F10A00", VA = "0x182F12400", Slot = "77")]
		public virtual Quaternion CalcElementRotation(StructureElement elementPrefab, int elementIndex)
		{
			return default(Quaternion);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x2F124A0", Offset = "0x2F10AA0", VA = "0x182F124A0", Slot = "78")]
		public virtual StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x2F12630", Offset = "0x2F10C30", VA = "0x182F12630", Slot = "79")]
		public virtual StructureElement AddElement(StructureElement elementPrefab, Vector3 position)
		{
			return null;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x2F127E0", Offset = "0x2F10DE0", VA = "0x182F127E0", Slot = "80")]
		public virtual StructureElement AddElement(StructureElement elementPrefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0000A0DC File Offset: 0x000082DC
		[Token(Token = "0x600108D")]
		[Address(RVA = "0x2F12960", Offset = "0x2F10F60", VA = "0x182F12960", Slot = "81")]
		public virtual bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x2F12B40", Offset = "0x2F11140", VA = "0x182F12B40", Slot = "82")]
		public virtual StructureElement GetElementToRemove(Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x2F12B50", Offset = "0x2F11150", VA = "0x182F12B50", Slot = "83")]
		public virtual bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0000A10C File Offset: 0x0000830C
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x2F12E10", Offset = "0x2F11410", VA = "0x182F12E10", Slot = "84")]
		public virtual float CalcTopHeight()
		{
			return 0f;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0000A124 File Offset: 0x00008324
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x2F13070", Offset = "0x2F11670", VA = "0x182F13070", Slot = "85")]
		public virtual float CalcBottomHeight()
		{
			return 0f;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "86")]
		public virtual void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0000A13C File Offset: 0x0000833C
		[Token(Token = "0x170003D9")]
		protected virtual bool BlockSelfLinking
		{
			[Token(Token = "0x6001093")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x2F13260", Offset = "0x2F11860", VA = "0x182F13260", Slot = "88")]
		public virtual string GetDirName(int dir)
		{
			return null;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x2E5E670", Offset = "0x2E5CC70", VA = "0x182E5E670", Slot = "89")]
		public virtual void SetStructureAtDir(Directions direction, IStructure structure)
		{
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x2F132B0", Offset = "0x2F118B0", VA = "0x182F132B0", Slot = "90")]
		public virtual void SetStructureAtDir(int direction, IStructure structure)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001097")]
		public virtual T GetStructureAtDir<T>(Directions direction) where T : class, IStructure
		{
			return null;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x2F13760", Offset = "0x2F11D60", VA = "0x182F13760", Slot = "92")]
		public virtual Structure GetStructureAtDir(Directions direction)
		{
			return null;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001099")]
		public T GetStructureAtDir<T>(int direction) where T : class, IStructure
		{
			return null;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0000A154 File Offset: 0x00008354
		[Token(Token = "0x600109A")]
		public virtual bool TryGetStructureAtDir<T>(Directions direction, out T structure) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0000A16C File Offset: 0x0000836C
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x2F137B0", Offset = "0x2F11DB0", VA = "0x182F137B0", Slot = "94")]
		public virtual bool TryGetStructureAtDir(Directions direction, out IStructure structure)
		{
			return default(bool);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0000A184 File Offset: 0x00008384
		[Token(Token = "0x600109C")]
		public bool TryGetStructureAtDir<T>(int direction, out T structure) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0000A19C File Offset: 0x0000839C
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x2E5E690", Offset = "0x2E5CC90", VA = "0x182E5E690", Slot = "95")]
		public virtual bool HasStructureAtDir(Directions direction)
		{
			return default(bool);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0000A1B4 File Offset: 0x000083B4
		[Token(Token = "0x600109E")]
		public virtual bool HasStructureAtDir<T>(Directions direction) where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0000A1CC File Offset: 0x000083CC
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x2F13810", Offset = "0x2F11E10", VA = "0x182F13810", Slot = "23")]
		public bool TryGetStructureDir(IStructure structure, out Directions dir)
		{
			return default(bool);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0000A1E4 File Offset: 0x000083E4
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x2F13870", Offset = "0x2F11E70", VA = "0x182F13870", Slot = "24")]
		public bool TryGetStructureDirNum(IStructure structure, out int dir)
		{
			return default(bool);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0000A1FC File Offset: 0x000083FC
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x2F138D0", Offset = "0x2F11ED0", VA = "0x182F138D0", Slot = "25")]
		public bool IsSupportedByAny()
		{
			return default(bool);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0000A214 File Offset: 0x00008414
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x2F13970", Offset = "0x2F11F70", VA = "0x182F13970", Slot = "97")]
		public virtual bool IsSupportingAny()
		{
			return default(bool);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0000A22C File Offset: 0x0000842C
		[Token(Token = "0x60010A3")]
		public virtual bool IsSupportingAny<T>() where T : class, IStructure
		{
			return default(bool);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0000A244 File Offset: 0x00008444
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x2F13A10", Offset = "0x2F12010", VA = "0x182F13A10", Slot = "99")]
		public virtual bool TryGetFallbackSupport(Directions dir, out IStructure fallbackStructure)
		{
			return default(bool);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0000A25C File Offset: 0x0000845C
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x2F13A70", Offset = "0x2F12070", VA = "0x182F13A70", Slot = "26")]
		public bool IsSupportedBy(IStructure otherStructure, out bool hasFallback)
		{
			return default(bool);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x2F13B80", Offset = "0x2F12180", VA = "0x182F13B80", Slot = "37")]
		public void ReplaceLinkedStructure(IStructure from, IStructure to)
		{
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x2F13EF0", Offset = "0x2F124F0", VA = "0x182F13EF0")]
		public void ClearLinkedStructure(IStructure from)
		{
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x2F14000", Offset = "0x2F12600", VA = "0x182F14000", Slot = "38")]
		public void SwapStructures(Directions from, Directions to)
		{
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x2F140F0", Offset = "0x2F126F0", VA = "0x182F140F0")]
		public List<Structure> ListSupportedStructures([Optional] IStructure exceptStructure, bool excludeIfFallbackSupport = true)
		{
			return null;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000A274 File Offset: 0x00008474
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x2F142D0", Offset = "0x2F128D0", VA = "0x182F142D0", Slot = "100")]
		public virtual bool IsSupportingStructure([Optional] IStructure exceptStructure, bool allowFallbacks = true)
		{
			return default(bool);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0000A28C File Offset: 0x0000848C
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "101")]
		public virtual bool IsMissingSupport()
		{
			return default(bool);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x2F143C0", Offset = "0x2F129C0", VA = "0x182F143C0")]
		[Conditional("UNITY_EDITOR")]
		public void TryShowCalculatedResistance(float resistance)
		{
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0000A2A4 File Offset: 0x000084A4
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x2F145B0", Offset = "0x2F12BB0", VA = "0x182F145B0", Slot = "102")]
		public virtual float GetStructuralResistanceFactor(int maxDepth)
		{
			return 0f;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0000A2BC File Offset: 0x000084BC
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "103")]
		public virtual float GetAdditionalElementHP()
		{
			return 0f;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x2F145C0", Offset = "0x2F12BC0", VA = "0x182F145C0", Slot = "104")]
		protected virtual NavMeshCutSetup CreateNavMeshCut()
		{
			return null;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x2F14760", Offset = "0x2F12D60", VA = "0x182F14760")]
		protected void EnableNavMeshCut(bool isEnabled, bool forceUpdate = false)
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected Structure()
		{
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0000A2D4 File Offset: 0x000084D4
		[Token(Token = "0x60010B6")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Structure[] _structures;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool ShowCalculatedResistance;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NavMeshCutSetup _navMeshCutSetup;
	}
}
