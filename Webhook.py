from flask import Flask, request, jsonify
import json
app = Flask(__name__)

@app.route('/webhook', methods=['POST'])
def handle_webhook():
    data = request.json
    print(json.dumps(data, indent=4))
    # Add your processing logic here
    return jsonify({'status': 'success'})
        
if __name__ == '__main__':
    app.run(port=5000, debug=True)