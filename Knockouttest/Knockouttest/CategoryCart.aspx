﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryCart.aspx.cs" Inherits="Knockouttest.CategoryCart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
body { font-family: arial; font-size: 14px; }

.liveExample { padding: 1em; background-color: #EEEEDD; border: 1px solid #CCC; max-width: 655px; }
.liveExample input { font-family: Arial; }
.liveExample b { font-weight: bold; }
.liveExample p { margin-top: 0.9em; margin-bottom: 0.9em; }
.liveExample select[multiple] { width: 100%; height: 8em; }
.liveExample h2 { margin-top: 0.4em; font-weight: bold; font-size: 1.2em; }

.liveExample th { text-align: left; font-weight: bold; }
.liveExample .price { text-align: right; padding-right: 2em; }
.liveExample .grandTotal { border-top: 1px solid silver; padding-top: 0.5em; font-size: 1.2em; }
.liveExample .grandTotal SPAN { font-weight: bold; }

.liveExample table, .liveExample td, .liveExample th { padding: 0.2em; border-width: 0; margin: 0; vertical-align: top; }
.liveExample td input, .liveExample td select { width: 8em; }
.liveExample td.quantity input { width: 4em; }
.liveExample td select { height: 1.8em; white-space: nowrap; }


li { list-style-type: disc; margin-left: 20px; }
    
    </style>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/knockout-3.2.0.js" type="text/javascript"></script>
    <script src="Scripts/sampleProductCategories.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class='liveExample'>
        <table width='100%'>
            <thead>
                <tr>
                    <th width='25%'>
                        Category
                    </th>
                    <th width='25%'>
                        Product
                    </th>
                    <th class='price' width='15%'>
                        Price
                    </th>
                    <th class='quantity' width='10%'>
                        Quantity
                    </th>
                    <th class='price' width='15%'>
                        Subtotal
                    </th>
                    <th width='10%'>
                    </th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lines'>
                <tr>
                    <td>
                        <select data-bind='options: sampleProductCategories, optionsText: "name", optionsCaption: "Select...", value: category'>
                        </select>
                    </td>
                    <td data-bind="with: category">
                        <select data-bind='options: products, optionsText: "name", optionsCaption: "Select...", value: $parent.product'>
                        </select>
                    </td>
                    <td class='price' data-bind='with: product'>
                        <span data-bind='text: formatCurrency(price)'></span>
                    </td>
                    <td class='quantity'>
                        <input data-bind='visible: product, value: quantity, valueUpdate: "afterkeydown"' />
                    </td>
                    <td class='price'>
                        <span data-bind='visible: product, text: formatCurrency(subtotal())'></span>
                    </td>
                    <td>
                        <a href='#' data-bind='click: $parent.removeLine'>Remove</a>
                    </td>
                </tr>
            </tbody>
        </table>
        <p class='grandTotal'>
            Total value: <span data-bind='text: formatCurrency(grandTotal())'></span>
        </p>
        <button data-bind='click: addLine'>
            Add product</button>
        <button data-bind='click: save'>
            Submit order</button>
    </div>
    </form>

    <script type="text/javascript">
        function formatCurrency(value) {
            return "$" + value.toFixed(2);
        }

        var CartLine = function () {
            var self = this;
            self.category = ko.observable();
            self.product = ko.observable();
            self.quantity = ko.observable(1);
            self.subtotal = ko.computed(function () {
                return self.product() ? self.product().price * parseInt("0" + self.quantity(), 10) : 0;
            });

            // Whenever the category changes, reset the product selection
            self.category.subscribe(function () {
                self.product(undefined);
            });
        };

        var Cart = function () {
            // Stores an array of lines, and from these, can work out the grandTotal
            var self = this;
            self.lines = ko.observableArray([new CartLine()]); // Put one line in by default
            self.grandTotal = ko.computed(function () {
                var total = 0;
                $.each(self.lines(), function () { total += this.subtotal() })
                return total;
            });

            // Operations
            self.addLine = function () { self.lines.push(new CartLine()) };
            self.removeLine = function (line) { self.lines.remove(line) };
            self.save = function () {
                var dataToSave = $.map(self.lines(), function (line) {
                    return line.product() ? {
                        productName: line.product().name,
                        quantity: line.quantity()
                    } : undefined
                });
                alert("Could now send this to server: " + JSON.stringify(dataToSave));
            };
        };

        ko.applyBindings(new Cart());    
    </script>
</body>
</html>