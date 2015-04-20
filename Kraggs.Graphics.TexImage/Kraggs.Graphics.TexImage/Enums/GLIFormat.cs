///////////////////////////////////////////////////////////////////////////////////
/// OpenGL Image (gli.g-truc.net)
///
/// Copyright (c) 2008 - 2012 G-Truc Creation (www.g-truc.net)
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
///
/// @ref core
/// @file gli/core/format.hpp
/// @date 2012-10-16 / 2012-10-16
/// @author Christophe Riccio
///////////////////////////////////////////////////////////////////////////////////

using System;

namespace Kraggs.Graphics.TexImage
{
    /// <summary>
    /// Enumeration into struct array with image format description.
    /// </summary>
    public enum GLIFormat
    {
        FORMAT_INVALID = -1,

        // unorm formats
        R8_UNORM = 0,
        RG8_UNORM,
        RGB8_UNORM,
        RGBA8_UNORM,

        R16_UNORM,
        RG16_UNORM,
        RGB16_UNORM,
        RGBA16_UNORM,

        RGB10A2_UNORM,

        // snorm formats
        R8_SNORM,
        RG8_SNORM,
        RGB8_SNORM,
        RGBA8_SNORM,

        R16_SNORM,
        RG16_SNORM,
        RGB16_SNORM,
        RGBA16_SNORM,

        // Unsigned integer formats
        R8U,
        RG8U,
        RGB8U,
        RGBA8U,

        R16U,
        RG16U,
        RGB16U,
        RGBA16U,

        R32U,
        RG32U,
        RGB32U,
        RGBA32U,

        RGB10A2U,

        // Signed integer formats
        R8I,
        RG8I,
        RGB8I,
        RGBA8I,

        R16I,
        RG16I,
        RGB16I,
        RGBA16I,

        R32I,
        RG32I,
        RGB32I,
        RGBA32I,

        // Floating formats
        R16F,
        RG16F,
        RGB16F,
        RGBA16F,

        R32F,
        RG32F,
        RGB32F,
        RGBA32F,

        // Packed formats
        RGB9E5,
        RG11B10F,
        R3G3B2,
        R5G6B5,
        RGB5A1,
        RGBA4,

        // Depth formats
        D16,
        D24X8,
        D24S8,
        D32F,
        D32FS8X24,

        // Compressed formats
        RGB_DXT1,
        RGBA_DXT1,
        RGBA_DXT3,
        RGBA_DXT5,

        R_ATI1N_UNORM,
        R_ATI1N_SNORM,
        RG_ATI2N_UNORM,
        RG_ATI2N_SNORM,
        RGB_BP_UNSIGNED_FLOAT,
        RGB_BP_SIGNED_FLOAT,
        RGB_BP_UNORM,
        RGB_PVRTC_4BPPV1,
        RGB_PVRTC_2BPPV1,
        RGBA_PVRTC_4BPPV1,
        RGBA_PVRTC_2BPPV1,

        ATC_RGB,
        ATC_RGBA_EXPLICIT_ALPHA,
        ATC_RGBA_INTERPOLATED_ALPHA,
        RGBA_ASTC_4x4,
        RGBA_ASTC_5x4,
        RGBA_ASTC_5x5,
        RGBA_ASTC_6x5,
        RGBA_ASTC_6x6,
        RGBA_ASTC_8x5,
        RGBA_ASTC_8x6,
        RGBA_ASTC_8x8,
        RGBA_ASTC_10x5,
        RGBA_ASTC_10x6,
        RGBA_ASTC_10x8,
        RGBA_ASTC_10x10,
        RGBA_ASTC_12x10,
        RGBA_ASTC_12x12,

        // sRGB formats
        SRGB8,
        SRGB8_ALPHA8,
        SRGB_DXT1,
        SRGB_ALPHA_DXT1,
        SRGB_ALPHA_DXT3,
        SRGB_ALPHA_DXT5,
        SRGB_BP_UNORM,
        SRGB_PVRTC_2BPPV1,
        SRGB_PVRTC_4BPPV1,
        SRGB_ALPHA_PVRTC_2BPPV1,
        SRGB_ALPHA_PVRTC_4BPPV1,
        SRGB8_ALPHA8_ASTC_4x4,
        SRGB8_ALPHA8_ASTC_5x4,
        SRGB8_ALPHA8_ASTC_5x5,
        SRGB8_ALPHA8_ASTC_6x5,
        SRGB8_ALPHA8_ASTC_6x6,
        SRGB8_ALPHA8_ASTC_8x5,
        SRGB8_ALPHA8_ASTC_8x6,
        SRGB8_ALPHA8_ASTC_8x8,
        SRGB8_ALPHA8_ASTC_10x5,
        SRGB8_ALPHA8_ASTC_10x6,
        SRGB8_ALPHA8_ASTC_10x8,
        SRGB8_ALPHA8_ASTC_10x10,
        SRGB8_ALPHA8_ASTC_12x10,
        SRGB8_ALPHA8_ASTC_12x12,

        FORMAT_LAST = SRGB8_ALPHA8_ASTC_12x12,
    }
}

