using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("NGUI/UI/NGUI Event System (UICamera)")]
	[ExecuteInEditMode]
	public class UICamera : MonoBehaviour
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000012")]
		[Obsolete("Use new OnDragStart / OnDragOver / OnDragOut / OnDragEnd events instead")]
		public bool stickyPress
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public static bool disableController
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2617C60", Offset = "0x2616260", VA = "0x182617C60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2617CD0", Offset = "0x26162D0", VA = "0x182617CD0")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		[Obsolete("Use lastEventPosition instead. It handles controller input properly.")]
		public static Vector2 lastTouchPosition
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2617D30", Offset = "0x2616330", VA = "0x182617D30")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2617D90", Offset = "0x2616390", VA = "0x182617D90")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public static Vector2 lastEventPosition
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2617E00", Offset = "0x2616400", VA = "0x182617E00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x26180C0", Offset = "0x26166C0", VA = "0x1826180C0")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public static UICamera.ControlScheme currentScheme
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2618130", Offset = "0x2616730", VA = "0x182618130")]
			get
			{
				return UICamera.ControlScheme.Mouse;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x26181C0", Offset = "0x26167C0", VA = "0x1826181C0")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public static KeyCode currentKey
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2618280", Offset = "0x2616880", VA = "0x182618280")]
			get
			{
				return KeyCode.None;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x26182E0", Offset = "0x26168E0", VA = "0x1826182E0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x17000018")]
		public static Ray currentRay
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2618540", Offset = "0x2616B40", VA = "0x182618540")]
			get
			{
				return default(Ray);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x17000019")]
		public static bool inputHasFocus
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2618760", Offset = "0x2616D60", VA = "0x182618760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		[Obsolete("Use delegates instead such as UICamera.onClick, UICamera.onHover, etc.")]
		public static GameObject genericEventHandler
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2618930", Offset = "0x2616F30", VA = "0x182618930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2618990", Offset = "0x2616F90", VA = "0x182618990")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x1700001B")]
		private bool handlesEvents
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2618A50", Offset = "0x2617050", VA = "0x182618A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001C")]
		public Camera cachedCamera
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2618BA0", Offset = "0x26171A0", VA = "0x182618BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700001D")]
		public static GameObject tooltipObject
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2618CE0", Offset = "0x26172E0", VA = "0x182618CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x1700001E")]
		public static bool isOverUI
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2618D40", Offset = "0x2617340", VA = "0x182618D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public static GameObject hoveredObject
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x26190B0", Offset = "0x26176B0", VA = "0x1826190B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2619380", Offset = "0x2617980", VA = "0x182619380")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public static GameObject controllerNavigationObject
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x261A340", Offset = "0x2618940", VA = "0x18261A340")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x261AA80", Offset = "0x2619080", VA = "0x18261AA80")]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public static GameObject selectedObject
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x261AEC0", Offset = "0x26194C0", VA = "0x18261AEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x261B0F0", Offset = "0x26196F0", VA = "0x18261B0F0")]
			set
			{
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x261BB70", Offset = "0x261A170", VA = "0x18261BB70")]
		public static bool IsPressed(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000022")]
		[Obsolete("Use either 'CountInputSources()' or 'activeTouches.Count'")]
		public static int touchCount
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x261BFB0", Offset = "0x261A5B0", VA = "0x18261BFB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x261BFF0", Offset = "0x261A5F0", VA = "0x18261BFF0")]
		public static int CountInputSources()
		{
			return 0;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000023")]
		public static int dragCount
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x261C390", Offset = "0x261A990", VA = "0x18261C390")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000024")]
		public static Camera mainCamera
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x261C730", Offset = "0x261AD30", VA = "0x18261C730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000025")]
		public static UICamera eventHandler
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x261C820", Offset = "0x261AE20", VA = "0x18261C820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x261C9F0", Offset = "0x261AFF0", VA = "0x18261C9F0")]
		private static int CompareFunc(UICamera a, UICamera b)
		{
			return 0;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x261CBC0", Offset = "0x261B1C0", VA = "0x18261CBC0")]
		private static Rigidbody FindRootRigidbody(Transform trans)
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x261CE00", Offset = "0x261B400", VA = "0x18261CE00")]
		private static Rigidbody2D FindRootRigidbody2D(Transform trans)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x261D040", Offset = "0x261B640", VA = "0x18261D040")]
		public static void Raycast(UICamera.MouseOrTouch touch)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x261D3C0", Offset = "0x261B9C0", VA = "0x18261D3C0")]
		public static bool Raycast(Vector3 inPos)
		{
			return default(bool);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x261F1F0", Offset = "0x261D7F0", VA = "0x18261F1F0")]
		private static bool IsVisible(Vector3 worldPoint, GameObject go)
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x261F330", Offset = "0x261D930", VA = "0x18261F330")]
		private static bool IsVisible(ref UICamera.DepthEntry de)
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x261F470", Offset = "0x261DA70", VA = "0x18261F470")]
		public static bool IsHighlighted(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x261F5C0", Offset = "0x261DBC0", VA = "0x18261F5C0")]
		public static UICamera FindCameraForLayer(int layer)
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x261F770", Offset = "0x261DD70", VA = "0x18261F770")]
		private static int GetDirection(KeyCode up, KeyCode down)
		{
			return 0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x261F8A0", Offset = "0x261DEA0", VA = "0x18261F8A0")]
		private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
		{
			return 0;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x261FAB0", Offset = "0x261E0B0", VA = "0x18261FAB0")]
		private static int GetDirection(string axis)
		{
			return 0;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x261FC70", Offset = "0x261E270", VA = "0x18261FC70")]
		public static void Notify(GameObject go, string funcName, object obj)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2620140", Offset = "0x261E740", VA = "0x182620140")]
		public static UICamera.MouseOrTouch GetMouse(int button)
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x26201C0", Offset = "0x261E7C0", VA = "0x1826201C0")]
		public static UICamera.MouseOrTouch GetTouch(int id, bool createIfMissing = false)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2620450", Offset = "0x261EA50", VA = "0x182620450")]
		public static void RemoveTouch(int id)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x26205E0", Offset = "0x261EBE0", VA = "0x1826205E0")]
		private void Awake()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2620C60", Offset = "0x261F260", VA = "0x182620C60")]
		private void OnEnable()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2620E60", Offset = "0x261F460", VA = "0x182620E60")]
		private void OnDisable()
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2620EE0", Offset = "0x261F4E0", VA = "0x182620EE0")]
		private void Start()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x26215B0", Offset = "0x261FBB0", VA = "0x1826215B0")]
		private void Update()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2621E40", Offset = "0x2620440", VA = "0x182621E40")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2622030", Offset = "0x2620630", VA = "0x182622030")]
		public void ProcessMouse()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2623260", Offset = "0x2621860", VA = "0x182623260")]
		public void ProcessTouches()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2623990", Offset = "0x2621F90", VA = "0x182623990")]
		private void ProcessFakeTouches()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2624090", Offset = "0x2622690", VA = "0x182624090")]
		public void ProcessOthers()
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x26252D0", Offset = "0x26238D0", VA = "0x1826252D0")]
		private void ProcessPress(bool pressed, float click, float drag)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2626CF0", Offset = "0x26252F0", VA = "0x182626CF0")]
		private void ProcessRelease(bool isMouse, float drag)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2627A30", Offset = "0x2626030", VA = "0x182627A30")]
		private bool HasCollider(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2627CA0", Offset = "0x26262A0", VA = "0x182627CA0")]
		public void ProcessTouch(bool pressed, bool released)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2628240", Offset = "0x2626840", VA = "0x182628240")]
		public static bool ShowTooltip(GameObject go)
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x26287D0", Offset = "0x2626DD0", VA = "0x1826287D0")]
		public static bool HideTooltip()
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2628820", Offset = "0x2626E20", VA = "0x182628820")]
		public UICamera()
		{
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x0")]
		public static bool SystemDisabled;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x8")]
		public static BetterList<UICamera> list;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		public static UICamera.GetKeyStateFunc GetKeyDown;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x18")]
		public static UICamera.GetKeyStateFunc GetKeyUp;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x20")]
		public static UICamera.GetKeyStateFunc GetKey;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		public static UICamera.GetAxisFunc GetAxis;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x30")]
		public static Func<Vector3> GetMousePosition;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x38")]
		public static UICamera.GetAnyKeyFunc GetAnyKeyDown;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x40")]
		public static UICamera.OnScreenResize onScreenResize;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x20")]
		public UICamera.EventType eventType;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x24")]
		public bool eventsGoToColliders;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask eventReceiverMask;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x2C")]
		public bool debug;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x2D")]
		public bool useMouse;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x2E")]
		public bool useTouch;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x2F")]
		public bool allowMultiTouch;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x30")]
		public bool useKeyboard;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x31")]
		public bool useController;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x32")]
		public bool stickyTooltip;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x34")]
		public float tooltipDelay;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x38")]
		public bool longPressTooltip;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x3C")]
		public float mouseDragThreshold;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x40")]
		public float mouseClickThreshold;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x44")]
		public float touchDragThreshold;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x48")]
		public float touchClickThreshold;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x4C")]
		public float rangeDistance;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x50")]
		public string horizontalAxisName;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x58")]
		public string verticalAxisName;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x60")]
		public string horizontalPanAxisName;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x68")]
		public string verticalPanAxisName;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x70")]
		public string scrollAxisName;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x78")]
		public bool commandClick;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x7C")]
		public KeyCode submitKey0;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x80")]
		public KeyCode submitKey1;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x84")]
		public KeyCode cancelKey0;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x88")]
		public KeyCode cancelKey1;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x48")]
		public static UICamera.OnCustomInput onCustomInput;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x50")]
		public static bool showTooltips;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x51")]
		private static bool mDisableController;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x54")]
		private static Vector2 mLastPos;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x5C")]
		public static Vector3 lastWorldPosition;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x68")]
		public static RaycastHit lastHit;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x98")]
		public static UICamera current;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xA0")]
		public static Camera currentCamera;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0xA8")]
		public static UICamera.OnSchemeChange onSchemeChange;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0xB0")]
		public static int currentTouchID;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0xB4")]
		private static KeyCode mCurrentKey;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xB8")]
		public static UICamera.MouseOrTouch currentTouch;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xC0")]
		private static bool mInputFocus;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0xC8")]
		private static GameObject mGenericHandler;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0xD0")]
		public static GameObject fallThrough;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0xD8")]
		public static UICamera.VoidDelegate onClick;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xE0")]
		public static UICamera.VoidDelegate onDoubleClick;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xE8")]
		public static UICamera.BoolDelegate onHover;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xF0")]
		public static UICamera.BoolDelegate onPress;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xF8")]
		public static UICamera.BoolDelegate onSelect;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x100")]
		public static UICamera.FloatDelegate onScroll;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x108")]
		public static UICamera.VectorDelegate onDrag;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x110")]
		public static UICamera.VoidDelegate onDragStart;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x118")]
		public static UICamera.ObjectDelegate onDragOver;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x120")]
		public static UICamera.ObjectDelegate onDragOut;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x128")]
		public static UICamera.VoidDelegate onDragEnd;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x130")]
		public static UICamera.ObjectDelegate onDrop;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x138")]
		public static UICamera.KeyCodeDelegate onKey;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x140")]
		public static UICamera.KeyCodeDelegate onNavigate;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x148")]
		public static UICamera.VectorDelegate onPan;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x150")]
		public static UICamera.BoolDelegate onTooltip;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x158")]
		public static UICamera.MoveDelegate onMouseMove;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x160")]
		private static UICamera.MouseOrTouch[] mMouse;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x168")]
		public static UICamera.MouseOrTouch controller;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x170")]
		public static List<UICamera.MouseOrTouch> activeTouches;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x178")]
		private static List<int> mTouchIDs;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x180")]
		private static int mWidth;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x184")]
		private static int mHeight;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x188")]
		private static GameObject mTooltip;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x90")]
		private Camera mCam;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x190")]
		private static float mTooltipTime;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x98")]
		private float mNextRaycast;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x194")]
		public static bool isDragging;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x198")]
		private static GameObject mRayHitObject;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x1A0")]
		private static GameObject mHover;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x1A8")]
		private static GameObject mSelected;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x1B0")]
		private static UICamera.DepthEntry mHit;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x1F8")]
		private static BetterList<UICamera.DepthEntry> mHits;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x200")]
		private static Plane m2DPlane;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x210")]
		private static float mNextEvent;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x214")]
		private static int mNotifying;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x218")]
		private static bool disableControllerCheck;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x219")]
		private static bool mUsingTouchEvents;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x220")]
		public static UICamera.GetTouchCountCallback GetInputTouchCount;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x228")]
		public static UICamera.GetTouchCallback GetInputTouch;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public enum ControlScheme
		{
			// Token: 0x040000A5 RID: 165
			[Token(Token = "0x40000A5")]
			Mouse,
			// Token: 0x040000A6 RID: 166
			[Token(Token = "0x40000A6")]
			Touch,
			// Token: 0x040000A7 RID: 167
			[Token(Token = "0x40000A7")]
			Controller
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public enum ClickNotification
		{
			// Token: 0x040000A9 RID: 169
			[Token(Token = "0x40000A9")]
			None,
			// Token: 0x040000AA RID: 170
			[Token(Token = "0x40000AA")]
			Always,
			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			BasedOnDelta
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		public class MouseOrTouch
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00002418 File Offset: 0x00000618
			[Token(Token = "0x17000026")]
			public float deltaTime
			{
				[Token(Token = "0x6000087")]
				[Address(RVA = "0x2629920", Offset = "0x2627F20", VA = "0x182629920")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00002430 File Offset: 0x00000630
			[Token(Token = "0x17000027")]
			public bool isOverUI
			{
				[Token(Token = "0x6000088")]
				[Address(RVA = "0x2629980", Offset = "0x2627F80", VA = "0x182629980")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2629C40", Offset = "0x2628240", VA = "0x182629C40")]
			public MouseOrTouch()
			{
			}

			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x10")]
			public KeyCode key;

			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 pos;

			// Token: 0x040000AE RID: 174
			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 lastPos;

			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			[FieldOffset(Offset = "0x24")]
			public Vector2 delta;

			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			[FieldOffset(Offset = "0x2C")]
			public Vector2 totalDelta;

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x38")]
			public Camera pressedCam;

			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x40")]
			public GameObject last;

			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			[FieldOffset(Offset = "0x48")]
			public GameObject current;

			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x50")]
			public GameObject pressed;

			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			[FieldOffset(Offset = "0x58")]
			public GameObject dragged;

			// Token: 0x040000B6 RID: 182
			[Token(Token = "0x40000B6")]
			[FieldOffset(Offset = "0x60")]
			public float pressTime;

			// Token: 0x040000B7 RID: 183
			[Token(Token = "0x40000B7")]
			[FieldOffset(Offset = "0x64")]
			public float clickTime;

			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x68")]
			public UICamera.ClickNotification clickNotification;

			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x6C")]
			public bool touchBegan;

			// Token: 0x040000BA RID: 186
			[Token(Token = "0x40000BA")]
			[FieldOffset(Offset = "0x6D")]
			public bool pressStarted;

			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			[FieldOffset(Offset = "0x6E")]
			public bool dragStarted;

			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			[FieldOffset(Offset = "0x70")]
			public int ignoreDelta;
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		public enum EventType
		{
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			World_3D,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			UI_3D,
			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			World_2D,
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			UI_2D
		}

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600008B RID: 139
		[Token(Token = "0x2000013")]
		public delegate bool GetKeyStateFunc(KeyCode key);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x0600008F RID: 143
		[Token(Token = "0x2000014")]
		public delegate float GetAxisFunc(string name);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000093 RID: 147
		[Token(Token = "0x2000015")]
		public delegate bool GetAnyKeyFunc();

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000097 RID: 151
		[Token(Token = "0x2000016")]
		public delegate void OnScreenResize();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600009B RID: 155
		[Token(Token = "0x2000017")]
		public delegate void OnCustomInput();

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x0600009F RID: 159
		[Token(Token = "0x2000018")]
		public delegate void OnSchemeChange();

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000A3 RID: 163
		[Token(Token = "0x2000019")]
		public delegate void MoveDelegate(Vector2 delta);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000A7 RID: 167
		[Token(Token = "0x200001A")]
		public delegate void VoidDelegate(GameObject go);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000AB RID: 171
		[Token(Token = "0x200001B")]
		public delegate void BoolDelegate(GameObject go, bool state);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060000AF RID: 175
		[Token(Token = "0x200001C")]
		public delegate void FloatDelegate(GameObject go, float delta);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000B3 RID: 179
		[Token(Token = "0x200001D")]
		public delegate void VectorDelegate(GameObject go, Vector2 delta);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x060000B7 RID: 183
		[Token(Token = "0x200001E")]
		public delegate void ObjectDelegate(GameObject go, GameObject obj);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000BB RID: 187
		[Token(Token = "0x200001F")]
		public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		private struct DepthEntry
		{
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			[FieldOffset(Offset = "0x0")]
			public int depth;

			// Token: 0x040000C3 RID: 195
			[Token(Token = "0x40000C3")]
			[FieldOffset(Offset = "0x4")]
			public RaycastHit hit;

			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 point;

			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			[FieldOffset(Offset = "0x40")]
			public GameObject go;
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public class Touch
		{
			// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Touch()
			{
			}

			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			[FieldOffset(Offset = "0x10")]
			public int fingerId;

			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x14")]
			public TouchPhase phase;

			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 position;

			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x20")]
			public int tapCount;
		}

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x060000C0 RID: 192
		[Token(Token = "0x2000022")]
		public delegate int GetTouchCountCallback();

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000C4 RID: 196
		[Token(Token = "0x2000023")]
		public delegate UICamera.Touch GetTouchCallback(int index);
	}
}
