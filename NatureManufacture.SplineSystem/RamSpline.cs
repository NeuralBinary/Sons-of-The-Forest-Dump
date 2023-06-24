using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[RequireComponent(typeof(MeshFilter))]
public class RamSpline : MonoBehaviour
{
	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2470D90", Offset = "0x246F390", VA = "0x182470D90")]
	public void Start()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2470DB0", Offset = "0x246F3B0", VA = "0x182470DB0")]
	public static RamSpline CreateSpline([Optional] Material splineMaterial, [Optional] List<Vector4> positions, string name = "RamSpline")
	{
		return null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x24710F0", Offset = "0x246F6F0", VA = "0x1824710F0")]
	public void AddPoint(Vector4 position)
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x24714A0", Offset = "0x246FAA0", VA = "0x1824714A0")]
	public void AddPointAfter(int i)
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2471A60", Offset = "0x2470060", VA = "0x182471A60")]
	public void ChangePointPosition(int i, Vector3 position)
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2471B50", Offset = "0x2470150", VA = "0x182471B50")]
	public void ChangePointPosition(int i, Vector4 position)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2471C20", Offset = "0x2470220", VA = "0x182471C20")]
	public void RemovePoint(int i)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2471D90", Offset = "0x2470390", VA = "0x182471D90")]
	public void RemovePoints(int fromID = -1)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2471FA0", Offset = "0x24705A0", VA = "0x182471FA0")]
	public void GenerateBeginningParentBased()
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2472410", Offset = "0x2470A10", VA = "0x182472410")]
	public void GenerateEndingParentBased()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x24728C0", Offset = "0x2470EC0", VA = "0x1824728C0")]
	public void GenerateSpline([Optional] List<RamSpline> generatedSplines)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2473D50", Offset = "0x2472350", VA = "0x182473D50")]
	private void CalculateCatmullRomSideSplines(List<Vector4> controlPoints, int pos)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x24749D0", Offset = "0x2472FD0", VA = "0x1824749D0")]
	private void CalculateCatmullRomSplineParameters(List<Vector4> controlPoints, int pos, bool initialPoints = false)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2474E90", Offset = "0x2473490", VA = "0x182474E90")]
	private void CalculateCatmullRomSpline(List<Vector3> controlPoints, int pos, ref List<Vector3> points)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x24752B0", Offset = "0x24738B0", VA = "0x1824752B0")]
	private void CalculatePointPosition(List<Vector3> controlPoints, int pos, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t, ref List<Vector3> points)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2475660", Offset = "0x2473C60", VA = "0x182475660")]
	private void CalculatePointParameters(List<Vector4> controlPoints, int pos, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2476420", Offset = "0x2474A20", VA = "0x182476420")]
	private int ClampListPos(int pos)
	{
		return 0;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2461390", Offset = "0x245F990", VA = "0x182461390")]
	private Vector3 GetCatmullRomPosition(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x24764B0", Offset = "0x2474AB0", VA = "0x1824764B0")]
	private Vector3 GetCatmullRomTangent(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2476790", Offset = "0x2474D90", VA = "0x182476790")]
	private Vector3 CalculateNormal(Vector3 tangent, Vector3 up)
	{
		return default(Vector3);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2476890", Offset = "0x2474E90", VA = "0x182476890")]
	private void GenerateMesh(ref Mesh mesh)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2479800", Offset = "0x2477E00", VA = "0x182479800")]
	public void GenerateMeshParts(Mesh baseMesh)
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x247AFD0", Offset = "0x24795D0", VA = "0x18247AFD0")]
	public void AddNoiseToWidths()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x247B180", Offset = "0x2479780", VA = "0x18247B180")]
	public void SimulateRiver(bool generate = true)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x247D700", Offset = "0x247BD00", VA = "0x18247D700")]
	public void ShowTerrainCarve(float differentSize = 0f)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x247F6A0", Offset = "0x247DCA0", VA = "0x18247F6A0")]
	public void TerrainCarve()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x24809D0", Offset = "0x247EFD0", VA = "0x1824809D0")]
	public void TerrainPaintMeshBased()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x24823C0", Offset = "0x24809C0", VA = "0x1824823C0")]
	public void TerrainClearFoliage(bool details = true)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2483B20", Offset = "0x2482120", VA = "0x182483B20")]
	private float FlowCalculate(float u, float normalY, Vector3 vertice)
	{
		return 0f;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2483D10", Offset = "0x2482310", VA = "0x182483D10")]
	public RamSpline()
	{
	}

	// Token: 0x04000097 RID: 151
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SplineProfile currentProfile;

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SplineProfile oldProfile;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RamSpline> beginnigChildSplines;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RamSpline> endingChildSplines;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RamSpline beginningSpline;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RamSpline endingSpline;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int beginningConnectionID;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int endingConnectionID;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float beginningMinWidth;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float beginningMaxWidth;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float endingMinWidth;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float endingMaxWidth;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int toolbarInt;

	// Token: 0x040000A4 RID: 164
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public bool invertUVDirection;

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	public bool uvRotation;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MeshFilter meshfilter;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Vector4> controlPoints;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<Quaternion> controlPointsRotations;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<Quaternion> controlPointsOrientation;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<Vector3> controlPointsUp;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Vector3> controlPointsDown;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<float> controlPointsSnap;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AnimationCurve meshCurve;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<AnimationCurve> controlPointsMeshCurves;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool normalFromRaycast;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
	public bool snapToTerrain;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public LayerMask snapMask;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<Vector3> points;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<Vector3> pointsUp;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<Vector3> pointsDown;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Vector3> points2;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<Vector3> verticesBeginning;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<Vector3> verticesEnding;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Vector3> normalsBeginning;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<Vector3> normalsEnding;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<float> widths;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<float> snaps;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<float> lerpValues;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<Quaternion> orientations;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public List<Vector3> tangents;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<Vector3> normalsList;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Color[] colors;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public List<Vector2> colorsFlowMap;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public List<Vector3> verticeDirection;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float floatSpeed;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public bool generateOnStart;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public float minVal;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public float maxVal;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public float width;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public int vertsInShape;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public float traingleDensity;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	public float uvScale;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Material oldMaterial;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public bool showVertexColors;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
	public bool showFlowMap;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x172")]
	public bool overrideFlowMap;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x173")]
	public bool drawOnMesh;

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	public bool drawOnMeshFlowMap;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x175")]
	public bool uvScaleOverride;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x176")]
	public bool debug;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x177")]
	public bool debugNormals;

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public bool debugTangents;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
	public bool debugBitangent;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17A")]
	public bool debugFlowmap;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17B")]
	public bool debugPoints;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	public bool debugPointsConnect;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17D")]
	public bool debugMesh;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public float distanceToDebug;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	public Color drawColor;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	public bool drawColorR;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x195")]
	public bool drawColorG;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x196")]
	public bool drawColorB;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x197")]
	public bool drawColorA;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public bool drawOnMultiple;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	public float flowSpeed;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public float flowDirection;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public AnimationCurve flowFlat;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public AnimationCurve flowWaterfall;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public bool noiseflowMap;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	public float noiseMultiplierflowMap;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public float noiseSizeXflowMap;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	public float noiseSizeZflowMap;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public float opacity;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	public float drawSize;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public float length;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	public float fulllength;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public float minMaxWidth;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
	public float uvWidth;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float uvBeginning;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool receiveShadows;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public ShadowCastingMode shadowCastingMode;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
	public bool generateMeshParts;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public int meshPartsCount;

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public List<Transform> meshesPartTransforms;

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public float simulatedRiverLength;

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	public int simulatedRiverPoints;

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public float simulatedMinStepSize;

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	public bool simulatedNoUp;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
	public bool simulatedBreakOnUp;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public int detailTerrain;

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	public int detailTerrainForward;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public float terrainAdditionalWidth;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	public float terrainSmoothMultiplier;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public bool overrideRiverRender;

	// Token: 0x040000FF RID: 255
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
	public bool noiseWidth;

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	public float noiseMultiplierWidth;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public float noiseSizeWidth;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	public bool noiseCarve;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public float noiseMultiplierInside;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
	public float noiseMultiplierOutside;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public float noiseSizeX;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	public float noiseSizeZ;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public bool noisePaint;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	public float noiseMultiplierInsidePaint;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public float noiseMultiplierOutsidePaint;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	public float noiseSizeXPaint;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public float noiseSizeZPaint;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public AnimationCurve terrainCarve;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public float distSmooth;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	public float distSmoothStart;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public AnimationCurve terrainPaintCarve;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public int currentSplatMap;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
	public bool mixTwoSplatMaps;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public int secondSplatMap;

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	public bool addCliffSplatMap;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public int cliffSplatMap;

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	public float cliffAngle;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public float cliffBlend;

	// Token: 0x04000117 RID: 279
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
	public int cliffSplatMapOutside;

	// Token: 0x04000118 RID: 280
	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public float cliffAngleOutside;

	// Token: 0x04000119 RID: 281
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
	public float cliffBlendOutside;

	// Token: 0x0400011A RID: 282
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public float distanceClearFoliage;

	// Token: 0x0400011B RID: 283
	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
	public float distanceClearFoliageTrees;

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public GameObject meshGO;
}
